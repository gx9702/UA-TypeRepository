using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using System.Reflection;
using System.Text;
using Microsoft.Office.Interop.Word;
using Word = Microsoft.Office.Interop.Word;
using Opc.Ua;
using MarkdownProcessor.NodeSet;

namespace MarkdownProcessor
{
    public class ModelImporter
    {
        private NamespaceTable NamespaceUris;
        private StringTable ServerUris;
        private Dictionary<NodeId, UANode> Nodes;
        private Dictionary<string, ModelInfo> Models;
        private Dictionary<NodeId, List<IndexedReference>> References;
        private List<ModelInfo> ModelNamespaceIndexes;

        private class Context
        {
            public UANodeSet NodeSet;
            public List<ushort> NamespaceMappings;
            public List<uint> ServerUriMappings;
            public Dictionary<string, NodeId> Aliases;
        }

        private class ModelInfo
        {
            public string NamespaceUri;
            public ushort NamespaceIndex;
            public string NodeSetPath;
            public string LinkBasePath;
            public DateTime PublicationDate;
            public UANodeSet NodeSet;
            public Dictionary<string, UANode> Types;
        }

        private class IndexedReference
        {
            public NodeId SourceId;
            public NodeId TargetId;
            public NodeId ReferenceTypeId;
            public bool IsForward;
        }

        public event EventHandler<ModelRequiredEventArgs> ModelRequired;

        public ModelImporter()
        {
            NamespaceUris = new NamespaceTable();
            ServerUris = new StringTable();
            Nodes = new Dictionary<NodeId, UANode>();
            Models = new Dictionary<string, ModelInfo>();
            References = new Dictionary<NodeId, List<IndexedReference>>();
            ModelNamespaceIndexes = new List<ModelInfo>();
        }

        private UANodeSet Read(Stream istrm)
        {
            using (StreamReader reader = new StreamReader(istrm))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(UANodeSet));
                return serializer.Deserialize(reader) as UANodeSet;
            }
        }

        private UANodeSet Read(string filePath)
        {
            using (Stream istrm = File.Open(filePath, FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                return Read(istrm);
            }
        }

        private UANodeSet Read(Assembly assembly, string resourceName)
        {
            if (assembly == null)
            {
                assembly = Assembly.GetCallingAssembly();
            }

            foreach (var ii in assembly.GetManifestResourceNames())
            {
                if (ii.EndsWith(resourceName, StringComparison.OrdinalIgnoreCase))
                {
                    using (Stream istrm = assembly.GetManifestResourceStream(ii))
                    {
                        return Read(istrm);
                    }
                }
            }

            throw new FileNotFoundException($"{assembly.FullName}.{resourceName}");
        }

        private NodeId ResolveNodeId(Context context, string sourceId)
        {
            NodeId nodeId = null;

            if (!context.Aliases.TryGetValue(sourceId, out nodeId))
            {
                nodeId = NodeId.Parse(sourceId);
                nodeId = new NodeId(nodeId.Identifier, context.NamespaceMappings[nodeId.NamespaceIndex]);
                context.Aliases[sourceId] = nodeId;
            }

            return nodeId;
        }

        private QualifiedName ResolveBrowseName(Context context, string sourceName)
        {
            QualifiedName browseName = QualifiedName.Parse(sourceName);

            if (browseName.NamespaceIndex != 0)
            {
                browseName = new QualifiedName(browseName.Name, context.NamespaceMappings[browseName.NamespaceIndex]);
            }

            return browseName;
        }

        private void EnsureInverseReferenceExists(Context context, IndexedReference reference)
        {
            // look up indexed references for the target,
            List<IndexedReference> references = null;

            if (!References.TryGetValue(reference.TargetId, out references))
            {
                References[reference.TargetId] = references = new List<IndexedReference>();

                // index references if they have not been indexed yet.
                UANode target = null;

                if (Nodes.TryGetValue(reference.TargetId, out target))
                {
                    if (target.References != null && target.References.Length > 0)
                    {
                        foreach (var ii in target.References)
                        {
                            var targetId = ResolveNodeId(context, ii.Value);
                            var referenceTypeId = ResolveNodeId(context, ii.ReferenceType);

                            references.Add(new IndexedReference()
                            {
                                SourceId = reference.TargetId,
                                TargetId = targetId,
                                ReferenceTypeId = referenceTypeId,
                                IsForward = ii.IsForward
                            });
                        }
                    }
                }
            }

            // search for existing reference.
            foreach (var ii in references)
            {
                if (reference.IsForward != ii.IsForward && reference.ReferenceTypeId == ii.ReferenceTypeId && reference.SourceId == ii.TargetId)
                {
                    return;
                }
            }

            // add inverse reference.
            references.Add(new IndexedReference()
            {
                SourceId = reference.TargetId,
                TargetId = reference.SourceId,
                ReferenceTypeId = reference.ReferenceTypeId,
                IsForward = !reference.IsForward
            });
        }

        private bool IsInTargetModel(Context context, NodeId nodeId)
        {
            if (nodeId == null)
            {
                return false;
            }

            if (context.NodeSet.Models != null)
            {
                foreach (var jj in context.NodeSet.Models)
                {
                    ModelInfo model = null;

                    if (Models.TryGetValue(jj.ModelUri, out model))
                    {
                        if (nodeId.NamespaceIndex == model.NamespaceIndex)
                        {
                            return true;
                        }
                    }
                }
            }

            return false;
        }

        private void LoadModel(ModelTableEntry required)
        {
            ModelInfo model = null;

            if (Models.TryGetValue(required.ModelUri, out model))
            {
                if (required.PublicationDateSpecified && required.PublicationDate <= model.PublicationDate)
                {
                    return;
                }
            }

            var callback = ModelRequired;

            if (callback != null)
            {
                var args = new ModelRequiredEventArgs(required.ModelUri, required.PublicationDate);
                callback(this, args);

                if (args.ModelFilePath != null)
                {
                    LoadModel(args.ModelFilePath);

                    ModelInfo info = null;

                    if (Models.TryGetValue(required.ModelUri, out info))
                    {
                        info.LinkBasePath = args.ModelLinkPath;
                    }
                }
            }
        }

        /// <summary>
        /// Creates an decoder to restore Variant values.
        /// </summary>
        private XmlDecoder CreateDecoder(Context context, XmlElement source)
        {
            ServiceMessageContext messageContext = new ServiceMessageContext();
            messageContext.NamespaceUris = this.NamespaceUris;
            messageContext.ServerUris = ServerUris;

            XmlDecoder decoder = new XmlDecoder(source, messageContext);

            NamespaceTable namespaceUris = new NamespaceTable();

            if (context.NodeSet.NamespaceUris != null)
            {
                for (int ii = 0; ii < context.NodeSet.NamespaceUris.Length; ii++)
                {
                    namespaceUris.Append(context.NodeSet.NamespaceUris[ii]);
                }
            }

            StringTable serverUris = new StringTable();

            if (context.NodeSet.ServerUris != null)
            {
                for (int ii = 0; ii < context.NodeSet.ServerUris.Length; ii++)
                {
                    serverUris.Append(context.NodeSet.ServerUris[ii]);
                }
            }

            decoder.SetMappingTables(namespaceUris, serverUris);

            return decoder;
        }

        public void LoadModel(string filePath)
        {
            // load the model from disk.
            var nodeset = Read(filePath);

            // recursively load all required models.
            if (nodeset.Models != null)
            {
                foreach (var ii in nodeset.Models)
                {
                    if (Models.ContainsKey(ii.ModelUri))
                    {
                        continue;
                    }

                    ModelInfo info = new ModelInfo()
                    {
                        NamespaceUri = ii.ModelUri,
                        NamespaceIndex = NamespaceUris.GetIndexOrAppend(ii.ModelUri),
                        NodeSetPath = filePath,
                        PublicationDate = (ii.PublicationDateSpecified) ? ii.PublicationDate : DateTime.MinValue,
                        LinkBasePath = String.Empty,
                        NodeSet = nodeset,
                        Types = new Dictionary<string, UANode>()
                    };

                    Models[ii.ModelUri] = info;

                    while (ModelNamespaceIndexes.Count <= info.NamespaceIndex) ModelNamespaceIndexes.Add(null);
                    ModelNamespaceIndexes[info.NamespaceIndex] = info;

                    if (ii.RequiredModel != null)
                    {
                        foreach (var jj in ii.RequiredModel)
                        {
                            LoadModel(jj);
                        }
                    }
                }
            }

            // index the namespaces.
            List<ushort> namespaceMappings = new List<ushort>();
            namespaceMappings.Add(0);

            if (nodeset.NamespaceUris != null && nodeset.NamespaceUris.Length > 0)
            {
                for (int ii = 0; ii < nodeset.NamespaceUris.Length; ii++)
                {
                    namespaceMappings.Add(NamespaceUris.GetIndexOrAppend(nodeset.NamespaceUris[ii]));
                }
            }

            // index the server uris.
            List<uint> serverUriMappings = new List<uint>();

            if (nodeset.ServerUris != null && nodeset.ServerUris.Length > 0)
            {
                for (int ii = 0; ii < nodeset.ServerUris.Length; ii++)
                {
                    serverUriMappings.Add(ServerUris.GetIndexOrAppend(nodeset.ServerUris[ii]));
                }
            }

            // index the aliases used in this file.
            Dictionary<string, NodeId> aliases = new Dictionary<string, NodeId>();

            if (nodeset.Aliases != null && nodeset.Aliases.Length > 0)
            {
                foreach (var ii in nodeset.Aliases)
                {
                    NodeId nodeId = NodeId.Parse(ii.Value);
                    nodeId = new NodeId(nodeId.Identifier, namespaceMappings[nodeId.NamespaceIndex]);
                    aliases[ii.Alias] = nodeId;
                }
            }

            Context context = new Context()
            {
                NodeSet = nodeset,
                NamespaceMappings = namespaceMappings,
                ServerUriMappings = serverUriMappings,
                Aliases = aliases
            };

            if (nodeset.Items != null && nodeset.Items.Length > 0)
            {
                // index the nodes defined in the model.
                foreach (var ii in nodeset.Items)
                {
                    NodeId nodeId = ResolveNodeId(context, ii.NodeId);
                    Nodes[nodeId] = ii;

                    ii.DecodedNodeId = nodeId;
                    ii.DecodedBrowseName = ResolveBrowseName(context, ii.BrowseName);

                    if (ii is UAObject)
                    {
                        ii.NodeClass = NodeClass.Object;
                    }
                    else if (ii is UAMethod)
                    {
                        ii.NodeClass = NodeClass.Method;
                    }
                    else if (ii is UAView)
                    {
                        ii.NodeClass = NodeClass.View;
                    }
                    else if (ii is UAObjectType)
                    {
                        ii.NodeClass = NodeClass.ObjectType;
                    }
                    else if (ii is UADataType)
                    {
                        ii.NodeClass = NodeClass.DataType;
                    }
                    else if (ii is UAReferenceType)
                    {
                        ii.NodeClass = NodeClass.ReferenceType;
                    }

                    var variable = ii as UAVariable;

                    if (variable != null)
                    {
                        nodeId = ResolveNodeId(context, variable.DataType);
                        variable.DecodedDataType = nodeId;
                        variable.NodeClass = NodeClass.Variable;

                        if (variable.Value != null)
                        {
                            XmlDecoder decoder = CreateDecoder(context, variable.Value);
                            Opc.Ua.TypeInfo typeInfo = null;
                            variable.DecodedValue = new Variant(decoder.ReadVariantContents(out typeInfo));
                            decoder.Close();
                        }
                    }

                    var variableType = ii as UAVariableType;

                    if (variableType != null)
                    {
                        nodeId = ResolveNodeId(context, variableType.DataType);
                        variableType.DecodedDataType = nodeId;
                        variableType.NodeClass = NodeClass.VariableType;

                        if (variableType.Value != null)
                        {
                            XmlDecoder decoder = CreateDecoder(context, variable.Value);
                            Opc.Ua.TypeInfo typeInfo = null;
                            variableType.DecodedValue = new Variant(decoder.ReadVariantContents(out typeInfo));
                            decoder.Close();
                        }
                    }

                    var dataType = ii as UADataType;

                    if (dataType != null)
                    {
                        if (dataType.Definition != null && dataType.Definition.Field != null)
                        {
                            foreach (var field in dataType.Definition.Field)
                            {
                                nodeId = ResolveNodeId(context, field.DataType);
                                field.DecodedDataType = nodeId;
                            }
                        }
                    }


                    var type = ii as UAType;

                    if (type != null)
                    {
                        var model = ModelNamespaceIndexes[ii.DecodedNodeId.NamespaceIndex];
                        model.Types[type.DecodedBrowseName.Name] = type;
                    }
                }

                // index the references from the nodes.
                foreach (var ii in Nodes)
                {
                    if (!IsInTargetModel(context, ii.Key))
                    {
                        continue;
                    }

                    var node = ii.Value;

                    // check if the references need to be indexed.
                    if (node.References != null && node.References.Length > 0)
                    {
                        List<IndexedReference> references = null;

                        if (!References.TryGetValue(ii.Key, out references))
                        {
                            References[ii.Key] = references = new List<IndexedReference>();

                            foreach (var jj in node.References)
                            {
                                NodeId targetId = ResolveNodeId(context, jj.Value);
                                NodeId referenceTypeId = ResolveNodeId(context, jj.ReferenceType);

                                var reference = new IndexedReference()
                                {
                                    SourceId = ii.Key,
                                    TargetId = targetId,
                                    ReferenceTypeId = referenceTypeId,
                                    IsForward = jj.IsForward
                                };

                                references.Add(reference);
                            }
                        }

                        // ensure any reverse reference exists.
                        foreach (var jj in references)
                        {
                            EnsureInverseReferenceExists(context, jj);
                        }
                    }
                }
            }
        }

        private string GetPath(string rootPath, UANode node)
        {
            string prefix = String.Empty;

            if (node is UAObjectType)
            {
                prefix += "ObjectTypes";
            }
            else if (node is UAVariableType)
            {
                prefix += "VariableTypes";
            }
            else if (node is UADataType)
            {
                prefix += "DataTypes";
            }
            else if (node is UAReferenceType)
            {
                prefix += "ReferenceTypes";
            }
            else
            {
                return null;
            }

            if (node.Category != null && node.Category.Length > 0)
            {
                if (node.Category[0].IndexOf('/') < 0)
                {
                    prefix = $"{node.Category[0]}/{prefix}";
                }
                else
                {
                    prefix = node.Category[0];
                }
            }

            var path = Path.Combine(rootPath, prefix, node.BrowseName);
            path = path.Replace("\\", "/");
            return path;
        }

        private NodeId FindFirstTarget(NodeId sourceId, NodeId referenceTypeId, bool isForward, QualifiedName targetName = null)
        {
            List<IndexedReference> references = null;

            if (!References.TryGetValue(sourceId, out references))
            {
                return null;
            }

            foreach (var ii in references)
            {
                if (referenceTypeId == ii.ReferenceTypeId && isForward == ii.IsForward)
                {
                    if (targetName != null)
                    {
                        UANode target = null;

                        if (Nodes.TryGetValue(ii.TargetId, out target))
                        {
                            if (target.DecodedBrowseName == targetName)
                            {
                                return ii.TargetId;
                            }
                        }

                        continue;
                    }

                    return ii.TargetId;
                }
            }

            return null;
        }

        private Variant GetVariableValue(NodeId sourceId)
        {
            UANode node = null;

            if (!Nodes.TryGetValue(sourceId, out node))
            {
                return Variant.Null;
            }

            UAVariable variable = node as UAVariable;

            if (variable != null)
            {
                return variable.DecodedValue;
            }

            UAVariableType vt = node as UAVariableType;

            if (vt != null)
            {
                return vt.DecodedValue;
            }

            return Variant.Null;
        }

        private RepositoryLink CreateLink(NodeId sourceId, NodeId referenceTypeId, bool isForward = true)
        {
            var targetId = FindFirstTarget(sourceId, referenceTypeId, isForward);

            if (targetId == null)
            {
                return null;
            }

            return CreateLink(sourceId, targetId);
        }

        private string GetPathFromNodeId(NodeId targetId)
        {
            UANode target = null;

            if (!Nodes.TryGetValue(targetId, out target))
            {
                return String.Empty;
            }

            var path = $"{target.NodeClass}s";

            if (target.Category != null && target.Category.Length > 0)
            {
                path = target.Category[0];

                if (targetId.NamespaceIndex == 0 && path.IndexOf('/') < 0)
                {
                    path = $"{path}/{target.NodeClass}s";
                }
            }

            path = $"{path}/{target.DecodedBrowseName.Name}";

            return path;
        }

        private RepositoryLink CreateLink(NodeId sourceId, NodeId targetId)
        {
            UANode target = null;

            if (!Nodes.TryGetValue(targetId, out target))
            {
                return null;
            }

            RepositoryLink link = new RepositoryLink();

            link.Name = target.DecodedBrowseName.Name;
            link.Path = GetPathFromNodeId(targetId);

            var sourcePath = GetPathFromNodeId(sourceId);

            var relativePath = "../";

            foreach (var ii in sourcePath)
            {
                if (ii == '/') relativePath += "../";
            }

            var model = ModelNamespaceIndexes[targetId.NamespaceIndex];

            if (sourceId.NamespaceIndex != targetId.NamespaceIndex)
            {
                if (model.LinkBasePath != null && model.LinkBasePath.StartsWith("http"))
                {
                    link.Path = $"{model.LinkBasePath}/{link.Path}";
                }
                else
                {
                    link.Path = $"{relativePath}{model.LinkBasePath}/{link.Path}";
                }
            }
            else
            {
                link.Path = $"{relativePath}{link.Path}";
            }

            return link;
        }

        private RepositoryReference CreateReference(NodeId sourceId, IndexedReference reference)
        {
            RepositoryReference output = new RepositoryReference();

            UANode target = null;

            if (Nodes.TryGetValue(reference.TargetId, out target))
            {
                output.ReferenceType = CreateLink(sourceId, reference.ReferenceTypeId);
                output.NodeClass = target.NodeClass;
                output.BrowseName = target.DecodedBrowseName.Name;
                output.TypeDefinition = CreateLink(reference.TargetId, ReferenceTypeIds.HasTypeDefinition, true);
                output.ModellingRule = CreateLink(reference.TargetId, ReferenceTypeIds.HasModellingRule, true);

                var vt = target as UAVariable;

                if (vt != null)
                {
                    output.ValueRank = vt.ValueRank;
                    output.DataType = CreateLink(sourceId, vt.DecodedDataType);
                }

                var mt = target as UAMethod;

                if (mt != null)
                {
                    var propertyId = FindFirstTarget(reference.TargetId, ReferenceTypeIds.HasProperty, true, BrowseNames.InputArguments);

                    if (propertyId != null)
                    {
                        var value = GetVariableValue(propertyId);
                        var arguments = ExtensionObject.ToArray(value.Value, typeof(Argument));

                        foreach (Argument argument in arguments)
                        {
                            output.InputArguments.Add(CreateArgument(sourceId, mt, argument));
                        }
                    }

                    propertyId = FindFirstTarget(reference.TargetId, ReferenceTypeIds.HasProperty, true, BrowseNames.OutputArguments);

                    if (propertyId != null)
                    {
                        var value = GetVariableValue(propertyId);
                        var arguments = ExtensionObject.ToArray(value.Value, typeof(Argument));

                        foreach (Argument argument in arguments)
                        {
                            output.InputArguments.Add(CreateArgument(sourceId, mt, argument));
                        }
                    }
                }
            }

            return output;
        }

        private RepositoryDataTypeField CreateField(NodeId sourceId, DataTypeField field)
        {
            RepositoryDataTypeField output = new RepositoryDataTypeField();

            output.Name = field.Name;
            output.DataType = CreateLink(sourceId, field.DecodedDataType);
            output.ValueRank = field.ValueRank;
            output.Value = field.Value;
            output.IsOptional = field.IsOptional;

            if (field.Description != null && field.Description.Length > 0)
            {
                output.Documentation = new List<string>() { field.Description[0].Value };
            }

            return output;
        }

        private RepositoryDataTypeField CreateArgument(NodeId sourceId, UAMethod method, Argument argument)
        {
            RepositoryDataTypeField output = new RepositoryDataTypeField();

            output.Name = argument.Name;
            output.DataType = CreateLink(sourceId, argument.DataType);
            output.ValueRank = argument.ValueRank;

            bool found = false;

            if (method.ArgumentDescription != null && method.ArgumentDescription.Length > 0)
            {
                foreach (var ii in method.ArgumentDescription)
                {
                    if (ii.Name == argument.Name)
                    {
                        if (!String.IsNullOrEmpty(ii.Documentation))
                        {
                            output.Documentation = new List<string>() { ii.Documentation };
                            found = true;
                            break;
                        }
                    }
                }
            }

            if (!found)
            {
                if (argument.Description != null)
                {
                    output.Documentation = new List<string>() { argument.Description.Text };
                }
            }

            return output;
        }

        private void IndexEntry(RepositoryIndex index, RepositoryEntry entry, string path, int start = 0)
        {
            var prefix = path;

            int end = path.IndexOf('/', start);

            if (end >= 0)
            {
                prefix = path.Substring(0, end);

                if (String.IsNullOrEmpty(prefix))
                {
                    index.Children.Add(entry);
                    entry.Parent = index;
                    return;
                }

                path = path.Substring(end + 1);
            }

            foreach (var ii in index.Children)
            {
                var subindex = ii as RepositoryIndex;

                if (subindex != null && subindex.Name == prefix)
                {
                    if (end >= 0)
                    {
                        IndexEntry(subindex, entry, path, 0);
                    }
                    else
                    {
                        subindex.Children.Add(entry);
                        entry.Parent = subindex;
                    }

                    return;
                }
            }

            RepositoryIndex newIndex = new RepositoryIndex()
            {
                Name = prefix,
                Children = new List<RepositoryEntry>()
            };

            index.Children.Add(newIndex);
            newIndex.Parent = index;

            if (end >= 0)
            {
                IndexEntry(newIndex, entry, path, 0);
            }
            else
            {
                newIndex.Children.Add(entry);
                entry.Parent = newIndex;
            }
        }

        public Repository CreateRepository(string modelUri)
        {
            var namespaceIndex = NamespaceUris.GetIndex(modelUri);

            if (namespaceIndex < 0)
            {
                throw new ArgumentException("Model is not recognized.", "modelUri");
            }

            Repository repository = new Repository();

            foreach (var ii in Nodes.Values)
            {
                if (namespaceIndex != ii.DecodedNodeId.NamespaceIndex)
                {
                    continue;
                }

                string path = $"{ii.NodeClass}s";

                if (ii.Category != null && ii.Category.Length > 0)
                {
                    path = ii.Category[0];

                    if (namespaceIndex == 0 && path.IndexOf('/') < 0)
                    {
                        path = $"{path}/{ii.NodeClass}s";
                    }
                }

                if (ii.NodeClass != NodeClass.DataType)
                {
                    if (ii is UAInstance)
                    {
                        if (ii.Category == null || ii.Category.Length == 0)
                        {
                            continue;
                        }
                    }

                    var gt = ii as UAType;
                    var ot = ii as UAObjectType;
                    var vt = ii as UAVariableType;

                    var entry = new RepositoryObjectVariableType();

                    entry.NodeId = ii.DecodedNodeId;
                    entry.NamespaceUri = this.ModelNamespaceIndexes[entry.NodeId.NamespaceIndex].NamespaceUri;
                    entry.Name = ii.DecodedBrowseName.Name;
                    entry.NodeClass = ii.NodeClass;

                    if (ii.Category != null)
                    {
                        entry.Categories = new List<string>(ii.Category);
                    }

                    if (!String.IsNullOrEmpty(ii.Documentation))
                    {
                        entry.Documentation = new List<string>() { ii.Documentation };
                    }
                    else if (ii.Description != null && ii.Description.Length > 0)
                    {
                        entry.Documentation = new List<string>() { ii.Description[0].Value };
                    }

                    entry.BaseType = CreateLink(ii.DecodedNodeId, ReferenceTypeIds.HasSubtype, false);

                    if (gt != null)
                    {
                        entry.IsAbstract = gt.IsAbstract;
                    }

                    if (vt != null)
                    {
                        entry.DataType = CreateLink(ii.DecodedNodeId, vt.DecodedDataType);
                        entry.ValueRank = vt.ValueRank;
                    }

                    List<IndexedReference> references = null;

                    if (References.TryGetValue(ii.DecodedNodeId, out references))
                    {
                        foreach (var jj in references)
                        {
                            if (jj.IsForward)
                            {
                                var reference = CreateReference(ii.DecodedNodeId, jj);
                                entry.References.Add(reference);
                            }
                        }
                    }

                    IndexEntry(repository, entry, path);
                }

                if (ii.NodeClass == NodeClass.DataType)
                {
                    var dt = ii as UADataType;

                    var entry = new RepositoryDataType();

                    entry.NodeId = ii.DecodedNodeId;
                    entry.NamespaceUri = this.ModelNamespaceIndexes[entry.NodeId.NamespaceIndex].NamespaceUri;
                    entry.Name = ii.DecodedBrowseName.Name;

                    if (ii.Category != null)
                    {
                        entry.Categories = new List<string>(ii.Category);
                    }

                    if (!String.IsNullOrEmpty(ii.Documentation))
                    {
                        entry.Documentation = new List<string>() { ii.Documentation };
                    }
                    else if (ii.Description != null && ii.Description.Length > 0)
                    {
                        entry.Documentation = new List<string>() { ii.Description[0].Value };
                    }

                    entry.BaseType = CreateLink(ii.DecodedNodeId, ReferenceTypeIds.HasSubtype, false);

                    List<IndexedReference> references = null;

                    if (References.TryGetValue(ii.DecodedNodeId, out references))
                    {
                        foreach (var jj in references)
                        {
                            if (jj.IsForward && jj.ReferenceTypeId != ReferenceTypeIds.HasEncoding)
                            {
                                var reference = CreateReference(ii.DecodedNodeId, jj);
                                entry.References.Add(reference);
                            }
                        }
                    }

                    if (dt != null)
                    {
                        entry.IsAbstract = dt.IsAbstract;
                        entry.DataTypeClass = DataTypeClass.Structure;

                        if (dt.Definition != null)
                        {
                            if (dt.Definition.IsOptionSet)
                            {
                                entry.DataTypeClass = DataTypeClass.OptionSet;
                            }
                            else if (dt.Definition.IsUnion)
                            {
                                entry.DataTypeClass = DataTypeClass.Union;
                            }

                            foreach (var jj in dt.Definition.Field)
                            {
                                var field = CreateField(ii.DecodedNodeId, jj);
                                entry.Fields.Add(field);

                                if (jj.Value >= 0 && entry.DataTypeClass == DataTypeClass.Structure)
                                {
                                    entry.DataTypeClass = DataTypeClass.Enumeration;
                                }
                            }
                        }
                    }

                    IndexEntry(repository, entry, path);
                }
            }

            return repository;
        }

        private string MergeDocumentation(List<string> descriptions)
        {
            if (descriptions == null || descriptions.Count == 0)
            {
                return null;
            }

            StringBuilder buffer = new StringBuilder();

            foreach (var ii in descriptions)
            {
                if (buffer.Length > 0)
                {
                    buffer.Append($"  {Environment.NewLine}");
                }

                buffer.Append($"{ii}");
            }

            return buffer.ToString();
        }

        private void MergeRepositoryDataType(string modelUri, Dictionary<string, UANode> nodesByType, RepositoryDataType entry)
        {
            UANode node = null;

            if (!nodesByType.TryGetValue(modelUri + entry.Name, out node))
            {
                node = new UADataType();
                nodesByType[modelUri + entry.Name] = node;
            }

            UADataType dataTypeNode = node as UADataType;
            dataTypeNode.Documentation = MergeDocumentation(entry.Documentation);
            dataTypeNode.IsAbstract = entry.IsAbstract;
            dataTypeNode.Category = entry.Categories.ToArray();

            foreach (var field in entry.Fields)
            {
                DataTypeField target = null;

                foreach (var ii in dataTypeNode.Definition.Field)
                {
                    if (ii.Name == field.Name)
                    {
                        target = ii;

                        var documentation = MergeDocumentation(field.Documentation);
                        var descriptions = new List<NodeSet.LocalizedText>();

                        if (target.Description != null)
                        {
                            descriptions.AddRange(target.Description);
                        }

                        if (descriptions.Count > 0)
                        {
                            descriptions[0] = new NodeSet.LocalizedText() { Value = documentation };
                        }
                        else
                        {
                            descriptions.Add(new NodeSet.LocalizedText() { Value = documentation });
                        }

                        target.Description = descriptions.ToArray();
                        break;
                    }
                }
            }

            foreach (var reference in entry.References)
            {
                List<IndexedReference> targets = null;

                if (References.TryGetValue(dataTypeNode.DecodedNodeId, out targets))
                {
                    foreach (var ii in targets)
                    {
                        UANode target = null;

                        if (ii.IsForward && Nodes.TryGetValue(ii.TargetId, out target))
                        {
                            if (target.DecodedBrowseName.Name == reference.BrowseName)
                            {
                                target.Documentation = MergeDocumentation(reference.Documentation);
                                break;
                            }
                        }
                    }
                }
            }
        }

        private void MergeRepositoryObjectVariableType(string modelUri, Dictionary<string, UANode> nodesByType, RepositoryObjectVariableType entry)
        {
            UANode node = null;

            if (!nodesByType.TryGetValue(modelUri + entry.Name, out node))
            {
                return;
            }

            UAType typeNode = node as UAType;

            typeNode.Documentation = MergeDocumentation(entry.Documentation);
            typeNode.IsAbstract = entry.IsAbstract;
            typeNode.Category = entry.Categories.ToArray();

            foreach (var reference in entry.References)
            {
                List<IndexedReference> targets = null;

                if (References.TryGetValue(typeNode.DecodedNodeId, out targets))
                {
                    foreach (var ii in targets)
                    {
                        UANode target = null;

                        if (ii.IsForward && Nodes.TryGetValue(ii.TargetId, out target))
                        {
                            if (target.DecodedBrowseName.Name == reference.BrowseName)
                            {
                                target.Documentation = MergeDocumentation(reference.Documentation);
                                break;
                            }
                        }
                    }
                }
            }
        }

        private void MergeRepositoryIndex(string modelUri, Dictionary<string, UANode> nodesByType, RepositoryIndex index)
        {
            foreach (var entry in index.Children)
            {
                RepositoryIndex childIndex = entry as RepositoryIndex;

                if (childIndex != null)
                {
                    MergeRepositoryIndex(modelUri, nodesByType, childIndex);
                    continue;
                }

                RepositoryObjectVariableType objectType = entry as RepositoryObjectVariableType;

                if (objectType != null)
                {
                    MergeRepositoryObjectVariableType(modelUri, nodesByType, objectType);
                    continue;
                }

                RepositoryDataType dataType = entry as RepositoryDataType;

                if (dataType != null)
                {
                    MergeRepositoryDataType(modelUri, nodesByType, dataType);
                    continue;
                }
            }
        }

        public void MergeRepository(string modelUri, Repository repository)
        {
            Dictionary<string, UANode> nodesByType = new Dictionary<string, UANode>();

            foreach (var ii in Nodes)
            {
                var nodeClass = ii.Value.NodeClass;

                if (nodeClass == NodeClass.ObjectType || nodeClass == NodeClass.VariableType || nodeClass == NodeClass.DataType || nodeClass == NodeClass.ReferenceType)
                {
                    var model = ModelNamespaceIndexes[ii.Key.NamespaceIndex];
                    nodesByType[model.NamespaceUri + ii.Value.DecodedBrowseName.Name] = ii.Value;
                }
            }

            MergeRepositoryIndex(modelUri, nodesByType, repository);
        }

        public void SaveNodeSet(string modelUri, string filePath)
        {
            ModelInfo info = null;

            if (Models.TryGetValue(modelUri, out info))
            {
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(UANodeSet));
                    serializer.Serialize(writer, info.NodeSet);
                }
            }
        }

        public void MergeWordDocument(string modelUri, string filePath)
        {
            Application word = null;
            Document document = null;

            try
            {
                word = new Application { Visible = false };
                word.Documents.Open(filePath);

                document = word.Documents[filePath];

                /*
                foreach (Paragraph paragraph in document.Content.Paragraphs)
                {
                    if (paragraph.OutlineLevel != WdOutlineLevel.wdOutlineLevelBodyText)
                    {
                        var heading = paragraph.Range.Text;
                        heading = heading.Trim();

                        UANode node = null;

                        if (ModelNamespaceIndexes[0].Types.TryGetValue(heading, out node))
                        {
                            StringBuilder buffer = new StringBuilder();

                            var next = paragraph.Next();

                            while (next != null && next.get_Style().NameLocal == "PARAGRAPH,PA")
                            {
                                if (buffer.Length > 0)
                                {
                                    buffer.Append(Environment.NewLine);
                                }

                                buffer.Append(next.Range.Text);
                                next = next.Next();
                            }

                            node.Documentation = buffer.ToString().Trim();
                        }
                    }
                }
                */

                List<NodeTable> nodes = new List<NodeTable>();
                List<StructureTable> structures = new List<StructureTable>();
                List<EnumerationTable> enumerations = new List<EnumerationTable>();
                List<OptionSetTable> optionsets = new List<OptionSetTable>();
                List<MethodTable> methods = new List<MethodTable>();
                List<BaseTable> unknown = new List<BaseTable>();

                foreach (Table table in document.Content.Tables)
                {
                    var section = FindSection(document.Content, document.Range(table.Range.Start - 1));
                    var title = FindTitle(document.Content, table);
                    var type = GetTableType(table);

                    if (type == TableType.Unknown)
                    {
                        unknown.Add(new BaseTable() { Section = section, Title = title });
                        continue;
                    }

                    if (type == TableType.Node)
                    {
                        var parsedTable = ParseNodeTable(section, title, table);

                        if (parsedTable != null)
                        {
                            nodes.Add(parsedTable);
                        }
                    }
                    else if (type == TableType.Structure)
                    {
                        var parsedTable = ParseStructureTable(section, title, table);

                        if (parsedTable != null)
                        {
                            structures.Add(parsedTable);
                        }
                    }
                    else if (type == TableType.Enumeration)
                    {
                        var parsedTable = ParseEnumerationTable(section, title, table);

                        if (parsedTable != null)
                        {
                            enumerations.Add(parsedTable);
                        }
                    }
                    else if (type == TableType.OptionSet)
                    {
                        var parsedTable = ParseOptionSetTable(section, title, table);

                        if (parsedTable != null)
                        {
                            optionsets.Add(parsedTable);
                        }
                    }
                    else if (type == TableType.Method)
                    {
                        var parsedTable = ParseMethodTable(section, title, table);

                        if (parsedTable != null)
                        {
                            methods.Add(parsedTable);
                        }
                    }
                }

                FileInfo file = new FileInfo(filePath);

                using (StreamWriter writer = new StreamWriter(Path.Combine(file.DirectoryName, "NodeSetReport.csv"), false, new UTF8Encoding(true)))
                {
                    writer.WriteLine($"Section,Table,Error,Description");

                    VerifyNodes(writer, nodes);
                    VerifyStructures(writer, structures);
                    VerifyEnumerations(writer, enumerations);
                    VerifyOptionSets(writer, optionsets);
                }
            }
            finally
            {
                if (document != null)
                {
                    document.Close(false);
                }

                if (word != null)
                {
                    word.Quit();
                }
            }
        }

        private void WriteError(StreamWriter writer, BaseTable table, ValidationError error)
        {
            writer.WriteLine($"{table.Section},{table.Title},{error.ID},{error.Text}");
        }

        private void VerifyNodes(StreamWriter writer, List<NodeTable> nodes)
        {
            for (int ii = 0; ii < nodes.Count; ii++)
            {
                var node = FindNodeByName(nodes[ii].BrowseName);

                if (node == null)
                {
                    WriteError(writer, nodes[ii], new ValidationError() { ID = "NotFound", Text = $"{nodes[ii].BrowseName} not found in NodeSet." });
                    continue;
                }

                var error = CheckSuperType(node, nodes[ii]);

                if (error != null)
                {
                    WriteError(writer, nodes[ii], error);
                }

                error = CheckIsAbstract(node, nodes[ii]);

                if (error != null)
                {
                    WriteError(writer, nodes[ii], error);
                }

                error = CheckDataType(node, nodes[ii]);

                if (error != null)
                {
                    WriteError(writer, nodes[ii], error);
                }

                error = CheckValueRank(node, nodes[ii]);

                if (error != null)
                {
                    WriteError(writer, nodes[ii], error);
                }

                foreach (var reference in nodes[ii].References)
                {
                    error = CheckReference(node, reference);

                    if (error != null)
                    {
                        WriteError(writer, nodes[ii], error);
                    }
                }
            }
        }

        private void VerifyStructures(StreamWriter writer, List<StructureTable> structures)
        {
            for (int ii = 0; ii < structures.Count; ii++)
            {
                UADataType node = FindNodeByName(structures[ii].Name) as UADataType;

                if (node == null)
                {
                    WriteError(writer, structures[ii], new ValidationError() { ID = "NotFound", Text = $"{structures[ii].Name} datatype not found in NodeSet." });
                    continue;
                }

                if (node.Definition == null || node.Definition.Field == null || node.Definition.Field.Length == 0)
                {
                    if (structures[ii].Fields.Count > 0)
                    {
                        WriteError(writer, structures[ii], new ValidationError() { ID = "MissingDataTypeDefinition", Text = $"{structures[ii].Name} datatype definition not found in NodeSet." });
                    }

                    continue;
                }

                for (int jj = 0; jj < structures[ii].Fields.Count; jj++)
                {
                    var error = CheckStructureField(node, structures[ii].Fields[jj], jj);

                    if (error != null)
                    {
                        WriteError(writer, structures[ii], error);
                    }
                }

                if (node.Definition.Field.Length > structures[ii].Fields.Count)
                {
                    WriteError(writer, structures[ii], new ValidationError() { ID = "ExtraDataTypeFields", Text = $"{structures[ii].Name} datatype has {node.Definition.Field.Length - structures[ii].Fields.Count} unexpected fields defined in NodeSet." });
                    continue;
                }
            }
        }

        bool HasSuperType(NodeId subtypeId, string superTypeName)
        {
            do
            {
                var supertypeId = FindFirstTarget(
                    subtypeId,
                    ReferenceTypes.HasSubtype,
                    false);

                if (NodeId.IsNull(supertypeId))
                {
                    return false;
                }

                UANode supertype = null;

                if (!Nodes.TryGetValue(supertypeId, out supertype))
                {
                    return false;
                }

                if (supertype.DecodedBrowseName.Name == superTypeName)
                {
                    return true;
                }

                subtypeId = supertypeId;
            }
            while (true);
        }

        private void VerifyEnumerations(StreamWriter writer, List<EnumerationTable> enumerations)
        {
            for (int ii = 0; ii < enumerations.Count; ii++)
            {
                var enumeration = enumerations[ii];

                UADataType node = FindNodeByName(enumeration.Name) as UADataType;

                if (node == null)
                {
                    WriteError(writer, enumeration, new ValidationError() { ID = "NotFound", Text = $"{enumeration.Name} enumeration not found in NodeSet." });
                    continue;
                }

                if (!HasSuperType(node.DecodedNodeId, "Enumeration"))
                {
                    WriteError(writer, enumeration, new ValidationError() { ID = "InvalidSuperType", Text = $"{enumeration.Name} DataType does not have a Enumeration as a supertype." });
                    continue;
                }

                if (node.Definition == null || node.Definition.Field == null || node.Definition.Field.Length == 0)
                {
                    if (enumeration.Fields.Count > 0)
                    {
                        WriteError(writer, enumeration, new ValidationError() { ID = "MissingDataTypeDefinition", Text = $"{enumeration.Name} DataType definition not found in NodeSet." });
                    }

                    continue;
                }

                for (int jj = 0; jj < enumeration.Fields.Count; jj++)
                {
                    var field1 = enumeration.Fields[jj];

                    if (node.Definition.Field.Length <= jj)
                    {
                        WriteError(writer, enumeration, new ValidationError() { ID = "MissingEnumerationField", Text = $"{field1.Name} not found in NodeSet." });
                        continue;
                    }

                    var field2 = node.Definition.Field[jj];

                    if (field1.Name != field2.Name)
                    {
                        WriteError(writer, enumeration, new ValidationError() { ID = "InvalidEnumerationField", Text = $"{field2.Name} found. {field1.Name} expected." });
                    }

                    if (field1.Value != field2.Value)
                    {
                        WriteError(writer, enumeration, new ValidationError() { ID = "InvalidEnumerationField", Text = $"{field2.Name} enumeration value mismatch. {field2.Value} found; {field1.Value} expected." });
                    }
                }

                if (node.Definition.Field.Length > enumeration.Fields.Count)
                {
                    WriteError(writer, enumeration, new ValidationError() { ID = "ExtraEnumerationFields", Text = $"{enumeration.Name} datatype has {node.Definition.Field.Length - enumeration.Fields.Count} unexpected fields defined in NodeSet." });
                    continue;
                }
            }
        }

        private void VerifyOptionSets(StreamWriter writer, List<OptionSetTable> optionsets)
        {
            for (int ii = 0; ii < optionsets.Count; ii++)
            {
                var optionset = optionsets[ii];

                UADataType node = FindNodeByName(optionset.Name) as UADataType;

                if (node == null)
                {
                    WriteError(writer, optionset, new ValidationError() { ID = "NotFound", Text = $"{optionset.Name} optionset not found in NodeSet." });
                    continue;
                }

                if (!HasSuperType(node.DecodedNodeId, "Number"))
                {
                    WriteError(writer, optionset, new ValidationError() { ID = "InvalidSuperType", Text = $"{optionset.Name} DataType does not have a Enumeration as a supertype." });
                    continue;
                }

                if (node.Definition == null || node.Definition.Field == null || node.Definition.Field.Length == 0)
                {
                    if (optionset.Bits.Count > 0)
                    {
                        WriteError(writer, optionset, new ValidationError() { ID = "MissingDataTypeDefinition", Text = $"{optionset.Name} DataType definition not found in NodeSet." });
                    }

                    continue;
                }

                for (int jj = 0; jj < optionset.Bits.Count; jj++)
                {
                    var field1 = optionset.Bits[jj];

                    if (node.Definition.Field.Length <= jj)
                    {
                        WriteError(writer, optionset, new ValidationError() { ID = "MissingOptionSetField", Text = $"{field1.Name} not found in NodeSet." });
                        continue;
                    }

                    var field2 = node.Definition.Field[jj];

                    if (field1.Name != field2.Name)
                    {
                        WriteError(writer, optionset, new ValidationError() { ID = "InvalidOptionSetField", Text = $"{field2.Name} found. {field1.Name} expected." });
                    }

                    if (field1.Value != field2.Value)
                    {
                        WriteError(writer, optionset, new ValidationError() { ID = "InvalidOptionSetField", Text = $"{field2.Name} bit value mismatch. {field2.Value} found; {field1.Value} expected." });
                    }
                }

                if (node.Definition.Field.Length > optionset.Bits.Count)
                {
                    WriteError(writer, optionset, new ValidationError() { ID = "ExtraEnumerationFields", Text = $"{optionset.Name} datatype has {node.Definition.Field.Length - optionset.Bits.Count} unexpected fields defined in NodeSet." });
                    continue;
                }
            }
        }

        private ValidationError CheckStructureField(UADataType node, StructureFieldTable field, int index)
        {
            if (node.Definition == null || node.Definition.Field == null || node.Definition.Field.Length <= index)
            {
                return new ValidationError() { ID = "MissingDataTypeDefinition", Text = $"{field.Name} datatype definition not found in NodeSet." };
            }

            var target = node.Definition.Field[index];

            if (target.Name != field.Name)
            {
                return new ValidationError() { ID = "InvalidStructureField", Text = $"Expected {field.Name}. Got {target.Name}." };
            }

            var error = CheckDataType(target.DecodedDataType, field.DataTypeName);

            if (error != null)
            {
                return error;
            }

            error = CheckValueRank(target.ValueRank, field.Name, field.ValueRank);

            if (error != null)
            {
                return error;
            }

            return null;
        }

        private ValidationError CheckReference(UANode source, NodeReferenceTable reference)
        {
            var referenceType = FindNodeByName(reference.ReferenceTypeName);

            if (referenceType == null)
            {
                return new ValidationError() { ID = "InvalidReferenceType", Text = $"ReferenceType {reference.ReferenceTypeName} not found." };
            }

            var targetId = FindFirstTarget(
                source.DecodedNodeId,
                referenceType.DecodedNodeId,
                true,
                new QualifiedName(reference.BrowseName, ModelNamespaceIndexes[0].NamespaceIndex));

            if (targetId == null)
            {
                return new ValidationError() { ID = "InvalidMissingReference", Text = $"{reference.ReferenceTypeName} not {reference.BrowseName} not found." };
            }

            UANode target = null;

            if (!Nodes.TryGetValue(targetId, out target))
            {
                return new ValidationError() { ID = "InvalidMissingReference", Text = $"{reference.ReferenceTypeName} not {reference.BrowseName} defined but not found." };
            }

            if (target.NodeClass != reference.NodeClass)
            {
                return new ValidationError() { ID = "InvalidNodeClass", Text = $"{reference.BrowseName} has NodeClass {target.NodeClass}. Expected {reference.NodeClass}." };
            }

            if (target.NodeClass == NodeClass.Variable)
            {
                var error = CheckDataType(target, reference.DataTypeName);

                if (error != null)
                {
                    return error;
                }

                error = CheckValueRank(target, reference.BrowseName, reference.ValueRank);

                if (error != null)
                {
                    return error;
                }
            }
            else
            {
                if (!String.IsNullOrEmpty(reference.DataTypeName))
                {
                    return new ValidationError() { ID = "InvalidDataType", Text = $"{reference.BrowseName} has DataType {reference.DataTypeName}. Expected no data type." };
                }
            }

            if (target.NodeClass == NodeClass.Object || target.NodeClass == NodeClass.Variable)
            {
                var error = CheckTypeDefinition(target, reference.TypeDefinitionName);

                if (error != null)
                {
                    return error;
                }
            }
            else
            {
                if (!String.IsNullOrEmpty(reference.TypeDefinitionName))
                {
                    return new ValidationError() { ID = "InvalidTypeDefinition", Text = $"{reference.BrowseName} has TypeDefinition {reference.TypeDefinitionName}. Expected no type definition." };
                }
            }

            if (target.NodeClass == NodeClass.Object || target.NodeClass == NodeClass.Variable || target.NodeClass == NodeClass.Method)
            {
                var error = CheckModellingRule(target, reference.ModellingRuleName);

                if (error != null)
                {
                    return error;
                }
            }
            else
            {
                if (!String.IsNullOrEmpty(reference.ModellingRuleName))
                {
                    return new ValidationError() { ID = "InvalidModellingRule", Text = $"{reference.BrowseName} has ModellingRule {reference.ModellingRuleName}. Expected no modelling rule." };
                }
            }

            return null;
        }

        private ValidationError CheckTypeDefinition(UANode source, string typeDefinitionName)
        {
            var typeDefinition = FindNodeByName(typeDefinitionName);

            if (typeDefinition == null)
            {
                return new ValidationError() { ID = "MissingTypeDefinition", Text = $"Node for {typeDefinitionName} not found." };
            }

            var targetId = FindFirstTarget(
                source.DecodedNodeId,
                ReferenceTypeIds.HasTypeDefinition,
                true);

            if (targetId == null)
            {
                return new ValidationError() { ID = "MissingTypeDefinition", Text = $"Node {source.DecodedBrowseName.Name} does not have a type definition." };
            }

            if (targetId != typeDefinition.DecodedNodeId)
            {
                return new ValidationError() { ID = "InvalidTypeDefinition", Text = $"Node {source.DecodedBrowseName.Name} has TypeDefinition {targetId}. Expected {typeDefinition.DecodedNodeId}." };
            }

            return null;
        }

        private ValidationError CheckModellingRule(UANode source, string modellingRuleName)
        {
            NodeId modellingRuleId = null;

            if (modellingRuleName != null)
            {
                switch (modellingRuleName)
                {
                    case BrowseNames.ModellingRule_Mandatory: { modellingRuleId = ObjectIds.ModellingRule_Mandatory; break; }
                    case BrowseNames.ModellingRule_MandatoryPlaceholder: { modellingRuleId = ObjectIds.ModellingRule_MandatoryPlaceholder; break; }
                    case BrowseNames.ModellingRule_Optional: { modellingRuleId = ObjectIds.ModellingRule_Optional; break; }
                    case BrowseNames.ModellingRule_OptionalPlaceholder: { modellingRuleId = ObjectIds.ModellingRule_OptionalPlaceholder; break; }
                    case BrowseNames.ModellingRule_ExposesItsArray: { modellingRuleId = ObjectIds.ModellingRule_ExposesItsArray; break; }
                }
            }

            if (modellingRuleId == null)
            {
                return new ValidationError() { ID = "MissingModellingRule", Text = $"{modellingRuleName} not found." };
            }

            var targetId = FindFirstTarget(
                source.DecodedNodeId,
                ReferenceTypeIds.HasModellingRule,
                true);

            if (targetId == null)
            {
                return new ValidationError() { ID = "MissingModellingRule", Text = $"Node {source.DecodedBrowseName.Name} does not have a type definition." };
            }

            if (targetId != modellingRuleId)
            {
                return new ValidationError() { ID = "InvalidModellingRule", Text = $"Node {source.DecodedBrowseName.Name} has ModellingRule {targetId}. Expected {modellingRuleId}." };
            }

            return null;
        }

        private ValidationError CheckDataType(UANode node, NodeTable table)
        {
            return CheckDataType(node, table.DataTypeName);
        }

        private ValidationError CheckDataType(UANode node, string dataTypeName)
        {
            NodeId dataTypeId = null;
            UAVariableType type = node as UAVariableType;

            if (type == null)
            {
                UAVariable instance = node as UAVariable;

                if (instance != null)
                {
                    dataTypeId = instance.DecodedDataType;
                }
            }
            else
            {
                dataTypeId = type.DecodedDataType;
            }

            return CheckDataType(dataTypeId, dataTypeName);
        }

        private ValidationError CheckDataType(NodeId dataTypeId, string dataTypeName)
        {
            if (dataTypeName != null)
            {
                if (dataTypeId == null)
                {
                    return new ValidationError() { ID = "InvalidDataType", Text = $"No datatype found. Expected {dataTypeName}." };
                }

                UANode dataType = null;

                if (!Nodes.TryGetValue(dataTypeId, out dataType))
                {
                    return new ValidationError() { ID = "InvalidDataType", Text = $"DataType {dataTypeId} not found." };
                }

                var actualName = dataType.DecodedBrowseName.Name;
                
                if (actualName != dataTypeName)
                {
                    if (actualName == "BaseDataType")
                    {
                        actualName = "Variant";
                    }
                    else if (actualName == "Structure")
                    {
                        actualName = dataTypeName;
                    }

                    if (actualName != dataTypeName)
                    {
                        return new ValidationError() { ID = "InvalidDataType", Text = $"Expected DataType {dataTypeName}. Got {dataType.DecodedBrowseName}" };
                    }
                }
            }
            else
            {
                if (dataTypeId != null)
                {
                    UANode dataType = null;
                    dataTypeName = dataTypeId.ToString();

                    if (Nodes.TryGetValue(dataTypeId, out dataType))
                    {
                        dataTypeName = dataType.DecodedBrowseName.Name;
                    }

                    return new ValidationError() { ID = "InvalidDataType", Text = $"Datatype {dataTypeName} found. Expected no datatype." };
                }
            }

            return null;
        }

        private ValidationError CheckValueRank(UANode node, NodeTable table)
        {
            return CheckValueRank(node, table.BrowseName, table.ValueRank);
        }

        private ValidationError CheckValueRank(UANode node, string browseName, int? expectedValueRank)
        {
            int valueRank = Int32.MinValue;
            UAVariableType type = node as UAVariableType;

            if (type == null)
            {
                UAVariable instance = node as UAVariable;

                if (instance != null)
                {
                    valueRank = instance.ValueRank;
                }
            }
            else
            {
                valueRank = type.ValueRank;
            }

            return CheckValueRank(valueRank, browseName, expectedValueRank);
        }

        private ValidationError CheckValueRank(int valueRank, string browseName, int? expectedValueRank)
        {
            if (expectedValueRank != null)
            {
                if (expectedValueRank.Value != valueRank)
                {
                    return new ValidationError() { ID = "InvalidValueRank", Text = $"Expected ValueRank={expectedValueRank.Value}. Got IsAbstract={valueRank}" };
                }
            }
            else
            {
                if (valueRank != Int32.MinValue)
                {
                    return new ValidationError() { ID = "InvalidValueRank", Text = $"ValueRank not defined but type {browseName} has ValueRank={valueRank}." };
                }
            }

            return null;
        }

        private ValidationError CheckIsAbstract(UANode node, NodeTable table)
        {
            UAType type = node as UAType;

            if (table.IsAbstract != null)
            {
                if (type == null)
                {
                    return new ValidationError() { ID = "InvalidIsAbstract", Text = $"IsAbstract defined but node {table.BrowseName} is not type." };
                }

                if (type.IsAbstract != table.IsAbstract.Value)
                {
                    return new ValidationError() { ID = "InvalidIsAbstract", Text = $"Expected IsAbstract={table.IsAbstract}. Got IsAbstract={type.IsAbstract}" };
                }
            }
            else
            {
                if (type != null && !type.IsAbstract)
                {
                    return new ValidationError() { ID = "InvalidIsAbstract", Text = $"IsAbstract not defined but type {table.BrowseName} has IsAbstract=True." };
                }
            }

            return null;
        }

        private ValidationError CheckSuperType(UANode node, NodeTable table)
        {
            var superTypeId = FindFirstTarget(node.DecodedNodeId, ReferenceTypeIds.HasSubtype, false);

            if (table.SuperTypeName == null)
            {
                if (superTypeId != null)
                {
                    return new ValidationError() { ID = "InvalidSuperType", Text = $"Supertype found. None expected." };
                }
            }
            else
            {
                if (superTypeId == null)
                {
                    return new ValidationError() { ID = "InvalidSuperType", Text = $"No supertype found. Expected {table.SuperTypeName}." };
                }

                UANode superType = null;

                if (!Nodes.TryGetValue(superTypeId, out superType))
                {
                    return new ValidationError() { ID = "InvalidSuperType", Text = $"Supertype {superTypeId} not defined." };
                }

                if (superType.DecodedBrowseName.Name != table.SuperTypeName)
                {
                    return new ValidationError() { ID = "InvalidSuperType", Text = $"Expected supertype {table.SuperTypeName}. Got {superType.DecodedBrowseName}" };
                }
            }

            return null;
        }

        public class ValidationError
        {
            public string ID;
            public string Text;
        }

        public enum TableType
        {
            Unknown,
            Node,
            Structure,
            Enumeration,
            OptionSet,
            Method
        }

        public class BaseTable
        {
            public string Section;
            public string Title;
        }

        public class NodeTable : BaseTable
        {
            public string BrowseName;
            public string Namespace;
            public int NamespaceIndex;
            public string DataTypeName;
            public int? ValueRank;
            public bool? IsAbstract;
            public string TypeDefinitionName;
            public string SuperTypeName;
            public List<NodeReferenceTable> References;
        }

        public class NodeReferenceTable
        {
            public string BrowseName;
            public NodeClass NodeClass;
            public string ReferenceTypeName;
            public string DataTypeName;
            public int ValueRank;
            public string TypeDefinitionName;
            public string ModellingRuleName;
        }

        public class StructureTable : BaseTable
        {
            public string Name;
            public string SuperTypeName;
            public List<StructureFieldTable> Fields;
        }

        public class StructureFieldTable
        {
            public string Name;
            public string DataTypeName;
            public int ValueRank;
        }

        public class EnumerationTable : BaseTable
        {
            public string Name;
            public string SuperTypeName;
            public List<EnumerationValueTable> Fields;
        }

        public class EnumerationValueTable
        {
            public string Name;
            public int Value;
        }

        public class OptionSetTable : BaseTable
        {
            public string Name;
            public string SuperTypeName;
            public List<OptionSetBitTable> Bits;
        }

        public class OptionSetBitTable
        {
            public string Name;
            public uint Value;
        }

        public class MethodTable : BaseTable
        {
            public string Name;
            public List<MethodArgumentTable> Arguments;
        }

        public class MethodArgumentTable
        {
            public string Name;
            public string DataTypeName;
            public int ValueRank;
            public bool IsOutput;
        }

        private UANode FindNodeByName(string name)
        {
            if (String.IsNullOrWhiteSpace(name))
            {
                return null;
            }

            UANode node = null;

            if (ModelNamespaceIndexes[0].Types.TryGetValue(name, out node))
            {
                return node;
            }

            for (int ii = 0; ii < ModelNamespaceIndexes.Count; ii++)
            {
                if (ModelNamespaceIndexes[ii].NamespaceIndex == 0)
                {
                    if (ModelNamespaceIndexes[0].Types.TryGetValue(name, out node))
                    {
                        return node;
                    }
                }
            }

            return null;
        }

        private bool ParseField(string value, bool defaultValue = false)
        {
            if (String.IsNullOrEmpty(value))
            {
                return defaultValue;
            }

            bool bit = false;

            if (!Boolean.TryParse(value, out bit))
            {
                bit = defaultValue;
            }

            return bit;
        }

        private NodeClass ParseNodeClass(string value, NodeClass defaultValue = NodeClass.Object)
        {
            if (String.IsNullOrEmpty(value))
            {
                return defaultValue;
            }

            NodeClass bit = NodeClass.Unspecified;

            if (!Enum.TryParse<NodeClass>(value, out bit))
            {
                bit = defaultValue;
            }

            return bit;
        }

        private int ParseValueRank(string value, int defaultValue = -1)
        {
            if (String.IsNullOrEmpty(value))
            {
                return defaultValue;
            }

            int index = value.IndexOf(' ');

            if (index >= 0)
            {
                value = value.Substring(0, index);
            }

            int number = 0;

            if (!Int32.TryParse(value, out number))
            {
                number = defaultValue;
            }

            return number;
        }

        private void ParseSuperType(IList<Cell> row, NodeTable entry)
        {
            string supertype = TrimCell(row, 0);

            if (supertype.StartsWith("Subtype"))
            {
                supertype = supertype.Substring("Subtype".Length);
                supertype = supertype.TrimStart();

                if (supertype.StartsWith("of"))
                {
                    supertype = supertype.Substring(2);
                    supertype = supertype.TrimStart();
                }

                if (supertype.StartsWith("the"))
                {
                    supertype = supertype.Substring(3);
                    supertype = supertype.TrimStart();
                }

                int index = supertype.IndexOf(' ');

                if (index >= 0)
                {
                    supertype = supertype.Substring(0, index);
                }

                entry.SuperTypeName = supertype;
            }
        }

        private NodeTable ParseNodeTable(string section, string title, Table table)
        {
            List<List<Cell>> rows = ParseTable(table);

            NodeTable entry = new NodeTable();
            entry.Section = section;
            entry.Title = title;

            int start = 0;

            for (int ii = 1; ii < rows.Count; ii++)
            {
                var row = rows[ii];

                if (IsReferenceList(row))
                {
                    start = ii + 1;
                    break;
                }

                if (row.Count == 1)
                {
                    ParseSuperType(row, entry);
                    continue;
                }

                string name = TrimCell(row, 0);
                string value = TrimCell(row, 1);

                if (name == null)
                {
                    continue;
                }

                switch (name)
                {
                    case "BrowseName":
                    {
                        entry.BrowseName = value;
                        break;
                    }

                    case "IsAbstract":
                    {
                        entry.IsAbstract = ParseField(value);
                        break;
                    }

                    case "DataType":
                    {
                        entry.DataTypeName = value;
                        break;
                    }

                    case "ValueRank":
                    {
                        entry.ValueRank = ParseValueRank(value);
                        break;
                    }

                    case "TypeDefinition":
                    {
                        entry.TypeDefinitionName = value;
                        break;
                    }
                }
            }

            entry.References = new List<NodeReferenceTable>();

            for (int ii = start; start > 0 && ii < rows.Count; ii++)
            {
                var row = rows[ii];

                string referenceTypeName = TrimCell(row, 0);

                if (String.IsNullOrEmpty(referenceTypeName))
                {
                    continue;
                }

                if (row.Count == 1)
                {
                    ParseSuperType(row, entry);
                    continue;
                }

                string nodeClass = TrimCell(row, 1);
                string browseName = TrimCell(row, 2);
                string dataTypeName = TrimCell(row, 3);
                string typeDefinitionName = TrimCell(row, 4);
                string modellingRuleName = TrimCell(row, row.Count-1);

                var reference = new NodeReferenceTable()
                {
                    ReferenceTypeName = referenceTypeName,
                    NodeClass = ParseNodeClass(nodeClass),
                    BrowseName = browseName,
                    DataTypeName = dataTypeName,
                    TypeDefinitionName = typeDefinitionName,
                    ModellingRuleName = modellingRuleName
                };

                if (reference.NodeClass != NodeClass.Object && reference.NodeClass != NodeClass.Variable && reference.NodeClass != NodeClass.Method)
                {
                    reference.TypeDefinitionName = null;
                    reference.ModellingRuleName = null;
                }

                if (reference.NodeClass != NodeClass.Variable)
                {
                    reference.DataTypeName = null;
                }
                else
                {
                    int index = reference.DataTypeName.LastIndexOf('[');

                    if (index >= 0)
                    {
                        reference.ValueRank = 1;
                        reference.DataTypeName = reference.DataTypeName.Substring(0, index).TrimEnd();
                    }
                    else
                    {
                        reference.ValueRank = -1;
                    }

                    if (String.IsNullOrEmpty(reference.TypeDefinitionName))
                    {
                        if (reference.ReferenceTypeName == "HasProperty")
                        {
                            reference.TypeDefinitionName = "PropertyType";
                            reference.ModellingRuleName = "Mandatory";
                        }
                    }
                }

                entry.References.Add(reference);
            }

            return entry;
        }
        
        private StructureTable ParseStructureTable(string section, string title, Table table)
        {
            List<List<Cell>> rows = ParseTable(table);

            StructureTable entry = new StructureTable();
            entry.Section = section;
            entry.Title = title;

            var row = rows[1];
            entry.Name = TrimCell(row, 0);
            entry.SuperTypeName = TrimCell(row, 1);
            entry.Fields = new List<StructureFieldTable>();

            for (int ii = 2; ii < rows.Count; ii++)
            {
                row = rows[ii];
                
                string name = TrimCell(row, 0);
                string dataType = TrimCell(row, 1);

                if (name == null)
                {
                    continue;
                }

                name = $"{Char.ToUpper(name[0])}{name.Substring(1)}";

                var field = new StructureFieldTable()
                {
                    Name = name,
                    DataTypeName = dataType,
                    ValueRank = ValueRanks.Scalar
                };

                int index = dataType.LastIndexOf("[");

                if (index >= 0)
                {
                    field.DataTypeName = dataType.Substring(0, index).TrimEnd();
                    field.ValueRank = ValueRanks.OneDimension;
                }

                entry.Fields.Add(field);
            }

            return entry;
        }

        private EnumerationTable ParseEnumerationTable(string section, string title, Table table)
        {
            List<List<Cell>> rows = ParseTable(table);

            EnumerationTable entry = new EnumerationTable();
            entry.Section = section;
            entry.Title = title;
            entry.Name = ParseTitle(title);
            entry.Fields = new List<EnumerationValueTable>();

            for (int ii = 1; ii < rows.Count; ii++)
            {
                var row = rows[ii];

                string name = TrimCell(row, 0);
                string value = TrimCell(row, 1);

                if (name == null)
                {
                    continue;
                }

                int index = name.LastIndexOf("_");

                if (index >= 0)
                {
                    value = name.Substring(index + 1);
                    name = name.Substring(0, index).TrimEnd();
                }

                var field = new EnumerationValueTable()
                {
                    Name = name
                };

                if (!Int32.TryParse(value, out field.Value))
                {
                    field.Value = 0;
                }

                entry.Fields.Add(field);
            }

            return entry;
        }

        private OptionSetTable ParseOptionSetTable(string section, string title, Table table)
        {
            List<List<Cell>> rows = ParseTable(table);

            OptionSetTable entry = new OptionSetTable();
            entry.Section = section;
            entry.Title = title;
            entry.Name = ParseTitle(title);
            entry.Bits = new List<OptionSetBitTable>();

            for (int ii = 1; ii < rows.Count; ii++)
            {
                var row = rows[ii];

                if (row.Count < 2)
                {
                    continue;
                }

                string name = TrimCell(row, 0);
                string value = TrimCell(row, 1);

                if (name == null)
                {
                    continue;
                }

                var field = new OptionSetBitTable()
                {
                    Name = name
                };

                if (!UInt32.TryParse(value, out field.Value))
                {
                    field.Value = 0;
                }

                entry.Bits.Add(field);
            }

            return entry;
        }

        private MethodTable ParseMethodTable(string section, string title, Table table)
        {
            List<List<Cell>> rows = ParseTable(table);

            Word.Range range = table.Range.Document.Range(table.Range.Start - 1);

            while (range.Paragraphs.Count == 0)
            {
                range = range.Document.Range(range.Start - 1);
            }

            var target = range.Paragraphs[1];

            while (target != null)
            {
                var text = target.Range.Text;

                if (!text.StartsWith("Signature"))
                {
                    target = target.Previous(1);
                    continue;
                }

                target = target.Next(2);
                break;
            }

            Dictionary<string, MethodArgumentTable> arguments = new Dictionary<string, MethodArgumentTable>();

            while (target != null)
            {
                var fields = target.Range.Text.Split();

                string direction = null;
                string dataType = null;
                string name = null;
                int valueRank = -1;

                foreach (var field in fields)
                {
                    if (String.IsNullOrWhiteSpace(field))
                    {
                        continue;
                    }

                    if (direction == null)
                    {
                        direction = field;
                        continue;
                    }

                    if (dataType == null)
                    {
                        dataType = field;
                        continue;
                    }

                    name = field;
                }

                if (name == null || dataType == null)
                {
                    break;
                }

                int index = dataType.LastIndexOf("[");

                if (index >= 0)
                {
                    dataType = dataType.Substring(0, index).TrimEnd();
                    valueRank = 1;
                }

                index = name.LastIndexOf(")");

                if (index >= 0)
                {
                    name = name.Substring(0, index).TrimEnd();
                }

                arguments[name] = new MethodArgumentTable()
                {
                    Name = name,
                    DataTypeName = dataType,
                    ValueRank = valueRank,
                    IsOutput = (direction == "[out]")
                };

                target = target.Next(1);
            }

            MethodTable entry = new MethodTable();
            entry.Section = section;
            entry.Title = title;
            entry.Name = ParseTitle(title);
            entry.Arguments = new List<MethodArgumentTable>();

            for (int ii = 1; ii < rows.Count; ii++)
            {
                var row = rows[ii];

                if (row.Count < 2)
                {
                    continue;
                }

                string name = TrimCell(row, 0);
                string value = TrimCell(row, 1);

                if (name == null)
                {
                    continue;
                }

                MethodArgumentTable argument = null;

                if (arguments.TryGetValue(name, out argument))
                {
                    entry.Arguments.Add(argument);
                }
            }

            return entry;
        }

        private List<List<Cell>> ParseTable(Table table)
        {
            int rowIndex = 1;
            List<Cell> cells = new List<Cell>();
            List<List<Cell>> rows = new List<List<Cell>>();

            foreach (Cell cell in table.Range.Cells)
            {
                if (cell.RowIndex != rowIndex)
                {
                    rows.Add(cells);
                    cells = new List<Cell>();
                }

                rowIndex = cell.RowIndex;

                while (cells.Count < cell.ColumnIndex - 1)
                {
                    cells.Add(null);
                }

                cells.Add(cell);
            }

            rows.Add(cells);
            return rows;
        }

        private string ParseTitle(string title)
        {
            var index = title.LastIndexOf(' ');

            if (index >= 0)
            {
                title = title.Substring(0, index).TrimEnd();
            }

            index = title.LastIndexOf(' ');

            if (index >= 0)
            {
                title = title.Substring(index + 1).TrimStart();
            }

            return title;
        }

        private string TrimCell(IList<Cell> cells, int index)
        {
            if (cells == null || cells.Count <= index || index < 0)
            {
                return String.Empty;
            }

            StringBuilder builder = new StringBuilder();

            int state = 0;

            foreach (var ch in cells[index].Range.Text)
            {
                if (ch == '\a')
                {
                    break;
                }

                if (!Char.IsLetterOrDigit(ch) && !Char.IsWhiteSpace(ch) && !Char.IsPunctuation(ch))
                {
                    continue;
                }

                if (state == 0)
                {
                    if (!Char.IsWhiteSpace(ch))
                    {
                        builder.Append(ch);
                        state++;
                    }

                    continue;
                }

                if (state == 1)
                {
                    builder.Append(ch);
                    continue;
                }
            }

            return builder.ToString().TrimEnd();
        }

        private bool IsReferenceList(List<Cell> row)
        {
            if (row.Count < 1)
            {
                return false;
            }

            if (row.Count < 4 || row.Count > 5)
            {
                return false;
            }

            var column1 = TrimCell(row, 0);
            var column2 = TrimCell(row, 1);
            var column3 = TrimCell(row, 2);

            if (column1 == "References" && column2 == "NodeClass" && column3 == "BrowseName")
            {
                return true;
            }

            return false;
        }

        private string FindSection(Word.Range start, Word.Range range)
        {
            while (range.Paragraphs.Count == 0)
            {
                range = range.Document.Range(range.Start - 1);
            }

            var target = range.Paragraphs[1];

            while (target != null && start.Start <= target.Range.Start)
            {
                string text = target.Range.Text;

                if (target.OutlineLevel != WdOutlineLevel.wdOutlineLevelBodyText)
                {
                    Style style = target.get_Style();

                    if (style.NameLocal.Contains("Heading") || style.NameLocal.Contains("heading") || style.NameLocal.Contains("TERM-number"))
                    {
                        return $"{target.Range.ListFormat.ListString} {target.Range.Text.Trim()}";
                    }
                }

                target = target.Previous(1);
            }

            return "";
        }

        private string FindTitle(Word.Range start, Table table)
        {
            Word.Range range = table.Range;

            while (range.Paragraphs.Count == 0)
            {
                range = range.Document.Range(range.Start - 1);
            }

            var target = range.Paragraphs[1];

            while (target != null && start.Start <= target.Range.Start)
            {
                if (target.OutlineLevel != WdOutlineLevel.wdOutlineLevelBodyText)
                {
                    break;
                }

                Style style = target.get_Style();

                if (style.NameLocal.Contains("title"))
                {
                    return $"{target.Range.ListFormat.ListString} {target.Range.Text.Trim()}";
                }

                if (target.Range.Text.StartsWith("Signature"))
                {
                    target = target.Next(1);

                    string text = target.Range.Text;

                    int index = text.LastIndexOf("(");

                    if (index >= 0)
                    {
                        text = text.Substring(0, index);
                    }

                    return $"{text.Trim()} Method";
                }

                target = target.Previous(1);
            }

            return "";
        }

        private TableType GetTableType(Table table)
        {
            if (table.Rows.Count < 1)
            {
                return TableType.Unknown;
            }

            List<Cell> header = new List<Cell>();
            List<Cell> second = new List<Cell>();

            foreach (Cell cell in table.Range.Cells)
            {
                if (cell.RowIndex == 1)
                {
                    header.Add(cell);
                    continue;
                }

                if (cell.RowIndex == 2)
                {
                    second.Add(cell);
                    continue;
                }

                if (cell.RowIndex == 3)
                {
                    break;
                }
            }

            var column1 = TrimCell(header, 0);
            var column2 = TrimCell(header, 1);

            if (header.Count == 2)
            {
                if (column1 == "Attributes" && column2 == "Value")
                {
                    return TableType.Node;
                }

                if (column1 == "Value" && column2 == "Description")
                {
                    return TableType.Enumeration;
                }

                if (column1 == "Argument" && column2 == "Description")
                {
                    return TableType.Method;
                }
            }

            if (header.Count == 3)
            {
                var column3 = TrimCell(header, 2);

                if (column1 == "Name" && column2 == "Type" && column3 == "Description")
                {
                    var type = TrimCell(second, 1);

                    if (type == "Structure")
                    {
                        return TableType.Structure;
                    }
                }

                if (column1 == "Value" && column2.Contains("Bit") && column3 == "Description")
                {
                    return TableType.OptionSet;
                }
            }

            return TableType.Unknown;
        }
    }

    public class ModelRequiredEventArgs : EventArgs
    {
        internal ModelRequiredEventArgs(string modelUri, DateTime publicationDate)
        {
            ModelUri = modelUri;
            PublicationDate = publicationDate;
            ModelFilePath = String.Empty;
            ModelLinkPath = String.Empty;
        }

        public string ModelUri { get; }

        public DateTime PublicationDate { get; }

        public string ModelFilePath { get; set; }

        public string ModelLinkPath { get; set; }
    }
}

namespace MarkdownProcessor.NodeSet
{
    partial class UANode
    {
        [XmlIgnore]
        public NodeId DecodedNodeId { get; set; }

        [XmlIgnore]
        public QualifiedName DecodedBrowseName { get; set; }

        [XmlIgnore]
        public NodeClass NodeClass { get; set; }

        public override string ToString()
        {
            if (String.IsNullOrEmpty(BrowseName))
            {
                return NodeId;
            }

            return BrowseName;
        }
    }

    partial class UAVariable
    {
        [XmlIgnore]
        public NodeId DecodedDataType { get; set; }

        [XmlIgnore]
        public Variant DecodedValue { get; set; }
    }

    partial class UAVariableType
    {
        [XmlIgnore]
        public NodeId DecodedDataType { get; set; }

        [XmlIgnore]
        public Variant DecodedValue { get; set; }
    }

    partial class DataTypeField
    {
        [XmlIgnore]
        public NodeId DecodedDataType { get; set; }
    }
}