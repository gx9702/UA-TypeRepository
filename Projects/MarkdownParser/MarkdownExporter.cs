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

        private void WriteParagraphs(StreamWriter writer, List<string> documentation, bool noFinalNewLine = false)
        {
            if (documentation != null)
            {
                bool written = false;

                foreach (var ii in documentation)
                {
                    if (written)
                    {
                        writer.WriteLine("  ");
                    }

                    writer.Write(ii);
                    written = true;
                }

                if (!noFinalNewLine)
                {
                    writer.WriteLine();
                }
            }
        }


        private void WriteMethod(StreamWriter writer, RepositoryReference reference)
        {
            var name = reference.BrowseName;
            name = name.Replace("<", "&lt;");
            name = name.Replace(">", "&gt;");

            bool hasArguments = (reference.InputArguments != null && reference.InputArguments.Count > 0) || (reference.OutputArguments != null && reference.OutputArguments.Count > 0);

            writer.WriteLine($"### <a name=\"{name}\"></a>{name}");
            WriteParagraphs(writer, reference.Documentation);

            const string indent = "    ";

            writer.WriteLine($"**Signature**");
            writer.WriteLine($"```");
            writer.Write($"{indent}{name}(");

            if (reference.InputArguments != null && reference.InputArguments.Count > 0)
            {
                writer.WriteLine();

                foreach (var arg in reference.InputArguments)
                {
                    writer.WriteLine($"{indent}{indent}[in]  {arg.DataType.Name} {arg.Name}");
                }
            }

            if (reference.OutputArguments != null && reference.OutputArguments.Count > 0)
            {
                foreach (var arg in reference.OutputArguments)
                {
                    writer.WriteLine($"{indent}{indent}[out] {arg.DataType.Name} {arg.Name}");
                }
            }

            writer.WriteLine($"{indent});");
            writer.WriteLine($"```");

            if (hasArguments)
            {
                writer.WriteLine();
                writer.WriteLine($"|Argument|Description|");
                writer.WriteLine($"|---|---|");

                if (reference.InputArguments != null && reference.InputArguments.Count > 0)
                {
                    foreach (var arg in reference.InputArguments)
                    {
                        writer.Write($"|{arg.Name}|");
                        WriteParagraphs(writer, arg.Documentation, true);
                        writer.WriteLine($"|");
                    }
                }

                if (reference.OutputArguments != null && reference.OutputArguments.Count > 0)
                {
                    foreach (var arg in reference.OutputArguments)
                    {
                        writer.Write($"|{arg.Name}|");
                        WriteParagraphs(writer, arg.Documentation, true);
                        writer.WriteLine($"|");
                    }
                }

                writer.WriteLine();
            }

            if (reference.StatusCodes != null && reference.StatusCodes.Count > 0)
            {
                writer.WriteLine($"**Method Result Codes**");
                writer.WriteLine();
                writer.WriteLine($"|Result Code|Description|");
                writer.WriteLine($"|---|---|");

                foreach (var statusCode in reference.StatusCodes)
                {
                    writer.Write($"|{statusCode.Code}|");
                    WriteParagraphs(writer, statusCode.Documentation, true);
                    writer.WriteLine($"|");
                }

                writer.WriteLine();
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

                WriteParagraphs(writer, entry.Documentation);

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
                        writer.Write($"|[{name}](#{name})");
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

                    foreach (var reference in entry.References)
                    {
                        if (reference.NodeClass == NodeClass.Method)
                        {
                            WriteMethod(writer, reference);
                            continue;
                        }

                        if (reference.Documentation != null && reference.Documentation.Count > 0)
                        {
                            var name = reference.BrowseName;
                            name = name.Replace("<", "&lt;");
                            name = name.Replace(">", "&gt;");

                            writer.WriteLine($"### <a name=\"{name}\"></a>{name}");
                            WriteParagraphs(writer, reference.Documentation);
                        }
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

                if (entry.Documentation != null)
                {
                    foreach (var description in entry.Documentation)
                    {
                        writer.WriteLine($"{description}  ");
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

                        if (field.Documentation != null)
                        {
                            foreach (var ii in field.Documentation)
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

                        if (field.Documentation != null)
                        {
                            foreach (var ii in field.Documentation)
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
