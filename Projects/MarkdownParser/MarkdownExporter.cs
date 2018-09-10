using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Opc.Ua;
using MarkdownProcessor.NodeSet;

namespace MarkdownProcessor
{
    public class MarkdownExporter
    {
        public void Export(RepositoryIndex index, string path)
        {
            if (path == null)
            {
                throw new ArgumentNullException("path");
            }

            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            var filePath = Path.Combine(path, "readme.md");

            using (var writer = new StreamWriter(filePath))
            {
                writer.WriteLine("<!-- index -->");
                writer.WriteLine($"## {index.Name}");

                if (index.Children != null)
                {
                    foreach (var child in index.Children)
                    {
                        writer.WriteLine($"* [{child.Name}]({child.Name}/readme.md)");
                    }
                }
            }

            if (index.Children != null)
            {
                foreach (var child in index.Children)
                {
                    Export(child, Path.Combine(path, child.Name));
                }
            }
        }

        public string Export(RepositoryLink link)
        {
            if (link != null)
            { 
                return $"[{link.Name}]({link.Path}/readme.md)";
            }

            return String.Empty;
        }

        public void Export(RepositoryEntry entry, string path)
        {
            var index = entry as RepositoryIndex;

            if (index != null)
            {
                Export(index, path);
            }

            var ovt = entry as RepositoryObjectVariableType;

            if (ovt != null)
            {
                Export(ovt, path);
            }

            var dt = entry as RepositoryDataType;

            if (dt != null)
            {
                Export(dt, path);
            }
        }

        public void Export(RepositoryObjectVariableType entry, string path)
        {
            if (path == null)
            {
                throw new ArgumentNullException("path");
            }

            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            var filePath = Path.Combine(path, "readme.md");

            using (var writer = new StreamWriter(filePath))
            {
                writer.WriteLine("<!-- objecttype -->");
                writer.WriteLine($"## {entry.Name}");

                if (entry.Description != null)
                {
                    foreach (var description in entry.Description)
                    {
                        writer.WriteLine($"## {description}  ");
                    }
                }

                writer.WriteLine($"The representation of the {entry.Name} {entry.NodeClass} in the address space is shown in the following table:  ");

                writer.WriteLine();
                writer.WriteLine($"|Name|Attribute|");
                writer.WriteLine($"|---|---|");
                writer.WriteLine($"|BrowseName|{entry.Name}|");
                writer.WriteLine($"|NodeClass|{entry.NodeClass}|");
                writer.WriteLine($"|IsAbtract|{entry.IsAbstract}|");
                writer.WriteLine($"|BaseType|{Export(entry.BaseType)}|");
                writer.WriteLine();

                if (entry.References != null && entry.References.Count > 0)
                {
                    writer.WriteLine($"The references from the {entry.Name} {entry.NodeClass} Node are shown in the following table:  ");

                    writer.WriteLine();
                    writer.WriteLine($"|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|");
                    writer.WriteLine($"|---|---|---|---|---|---|");

                    foreach (var reference in entry.References)
                    {
                        var name = reference.BrowseName;
                        name = name.Replace("<", "&lt;");
                        name = name.Replace(">", "&gt;");

                        writer.Write($"|{Export(reference.ReferenceType)}");
                        writer.Write($"|{reference.NodeClass}");
                        writer.Write($"|{name}");
                        writer.Write($"|{Export(reference.DataType)}");

                        if (reference.DataType != null)
                        {
                            if (reference.ValueRank != ValueRanks.Scalar)
                            {
                                writer.Write("[]");
                            }
                        }

                        writer.Write($"|{Export(reference.TypeDefinition)}");
                        writer.Write($"|{Export(reference.ModellingRule)}");
                        writer.WriteLine($"|");
                    }

                    writer.WriteLine();
                }
            }
        }

        public void Export(RepositoryDataType entry, string path)
        {
            if (path == null)
            {
                throw new ArgumentNullException("path");
            }

            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            var filePath = Path.Combine(path, "readme.md");

            using (var writer = new StreamWriter(filePath))
            {
                writer.WriteLine("<!-- datatype -->");
                writer.WriteLine($"## {entry.Name}");

                if (entry.Description != null)
                {
                    foreach (var description in entry.Description)
                    {
                        writer.WriteLine($"## {description}  ");
                    }
                }

                writer.WriteLine($"<!-- end of description -->");
                writer.WriteLine($"The fields of the {entry.Name} DataType are defined in the following table:  ");

                if (entry.DataTypeClass == DataTypeClass.Structure || entry.DataTypeClass == DataTypeClass.Union)
                {
                    writer.WriteLine();
                    writer.WriteLine($"|Name|Type|Description|");
                    writer.WriteLine($"|---|---|---|");

                    writer.WriteLine($"|{entry.Name}|{entry.DataTypeClass}||");

                    foreach (var field in entry.Fields)
                    {
                        StringBuilder description = new StringBuilder();

                        if (field.Description != null)
                        {
                            foreach (var ii in field.Description)
                            {
                                if (description.Length > 0)
                                {
                                    description.Append($"  {Environment.NewLine}");
                                }

                                description.Append($"{ii}");

                                if (!ii.EndsWith("."))
                                {
                                    description.Append(".");
                                }
                            }
                        }

                        var name = field.Name.Substring(0, 1).ToLower() + field.Name.Substring(1);

                        if (field.ValueRank != ValueRanks.Scalar)
                        {
                            writer.WriteLine($"|&nbsp;&nbsp;&nbsp;&nbsp;{name}|{Export(field.DataType)}[]|{description}|");
                        }
                        else
                        {
                            writer.WriteLine($"|&nbsp;&nbsp;&nbsp;&nbsp;{name}|{Export(field.DataType)}|{description}|");
                        }
                    }
                }
                else
                {
                    var columnName = (entry.DataTypeClass == DataTypeClass.OptionSet) ? "Bit No." : "Value";

                    writer.WriteLine();
                    writer.WriteLine($"|Name|{columnName}| Description|");
                    writer.WriteLine($"|---|---|---|");

                    foreach (var field in entry.Fields)
                    {
                        StringBuilder description = new StringBuilder();

                        if (field.Description != null)
                        {
                            foreach (var ii in field.Description)
                            {
                                if (description.Length > 0)
                                {
                                    description.Append($"  {Environment.NewLine}");
                                }

                                description.Append($"{ii}");

                                if (!ii.EndsWith("."))
                                {
                                    description.Append(".");
                                }
                            }
                        }

                        writer.WriteLine($"|{field.Name}|{field.Value}|{description}|");
                    }
                }

                writer.WriteLine();

                writer.WriteLine($"The representation of the {entry.Name} DataType in the address space is shown in the following table:  ");

                writer.WriteLine();
                writer.WriteLine($"|Name|Attribute|");
                writer.WriteLine($"|---|---|");
                writer.WriteLine($"|BrowseName|{entry.Name}|");
                writer.WriteLine($"|IsAbtract|{entry.IsAbstract}|");
                writer.WriteLine($"|BaseType|{Export(entry.BaseType)}|");
                writer.WriteLine();

                if (entry.References != null && entry.References.Count > 0)
                {
                    writer.WriteLine($"The references from the {entry.Name} DataType Node are shown in the following table:  ");

                    writer.WriteLine();
                    writer.WriteLine($"|Reference|NodeClass|BrowseName|DataType|TypeDefinition|ModellingRule|");
                    writer.WriteLine($"|---|---|---|---|---|---|");

                    foreach (var reference in entry.References)
                    {
                        writer.Write($"|{Export(reference.ReferenceType)}");
                        writer.Write($"|{reference.NodeClass}");
                        writer.Write($"|{reference.BrowseName}");
                        writer.Write($"|{Export(reference.DataType)}");

                        if (reference.DataType != null)
                        {
                            if (reference.ValueRank != ValueRanks.Scalar)
                            {
                                writer.Write("[]");
                            }
                        }

                        writer.Write($"|{Export(reference.TypeDefinition)}");
                        writer.Write($"|{Export(reference.ModellingRule)}");
                        writer.WriteLine($"|");
                    }

                    writer.WriteLine();
                }
            }
        }
    }
}
