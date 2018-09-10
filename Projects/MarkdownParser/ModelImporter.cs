using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using System.Reflection;
using System.Text;
using Microsoft.Office.Interop.Word;
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
                        NodeSet = nodeset
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

                if (ii.NodeClass == NodeClass.ObjectType || ii.NodeClass == NodeClass.ReferenceType || ii.NodeClass == NodeClass.VariableType)
                {
                    var ot = ii as UAObjectType;
                    var vt = ii as UAVariableType;

                    var entry = new RepositoryObjectVariableType();

                    entry.Name = ii.DecodedBrowseName.Name;
                    entry.NodeClass = ii.NodeClass;

                    if (!String.IsNullOrEmpty(ii.Documentation))
                    {
                        entry.Documentation = new List<string>() { ii.Documentation };
                    }
                    else if (ii.Description != null && ii.Description.Length > 0)
                    {
                        entry.Documentation = new List<string>() { ii.Description[0].Value };

                        // clear the description field to avoid redundant information in file.
                        if (ii.Description.Length == 1)
                        {
                            ii.Description = null;
                        }
                    }

                    entry.BaseType = CreateLink(ii.DecodedNodeId, ReferenceTypeIds.HasSubtype, false);

                    if (ot != null)
                    {
                        entry.IsAbstract = ot.IsAbstract;
                    }

                    if (vt != null)
                    {
                        entry.IsAbstract = vt.IsAbstract;
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

                    entry.Name = ii.DecodedBrowseName.Name;

                    if (!String.IsNullOrEmpty(ii.Documentation))
                    {
                        entry.Documentation = new List<string>() { ii.Documentation };
                    }
                    else if (ii.Description != null && ii.Description.Length > 0)
                    {
                        entry.Documentation = new List<string>() { ii.Description[0].Value };

                        // clear the description field to avoid redundant information in file.
                        if (ii.Description.Length == 1)
                        {
                            ii.Description = null;
                        }
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
                node = new UAObjectType();
            }

            UAType typeNode = node as UAType;
            typeNode.Documentation = MergeDocumentation(entry.Documentation);

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

            Application word = null;
            Document document = null;

            try
            {
                word = new Application { Visible = false };
                word.Documents.Open(filePath);

                document = word.Documents[filePath];

                foreach (Paragraph paragraph in document.Content.Paragraphs)
                {
                    if (paragraph.OutlineLevel != WdOutlineLevel.wdOutlineLevelBodyText)
                    {
                        var heading = paragraph.Range.Text;
                        heading = heading.Trim();

                        UANode node = null;

                        if (nodesByType.TryGetValue(modelUri + heading, out node))
                        {
                            StringBuilder buffer = new StringBuilder();

                            var next = paragraph.Next();

                            while (next != null && next.get_Style().NameLocal == "PARAGRAPH,PA")
                            {
                                buffer.Append(next.Range.Text);
                                next = next.Next();
                            }

                            node.Documentation = buffer.ToString().Trim();
                        }
                    }
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