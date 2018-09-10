using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Markdig;
using Markdig.Syntax;
using Markdig.Syntax.Inlines;
using Markdig.Extensions.Tables;
using Opc.Ua;

namespace MarkdownProcessor
{
    public enum MarkdownDirectoryType
    { 
        Index = 0,
        ObjectType = 1,
        DataType = 2
    }

    public class MarkdownImporter
    {
        private Repository m_repository;

        private RepositoryEntry ImportIndexEntry(DirectoryInfo currentPath, ListItemBlock block)
        {
            if (block.LastChild == null)
            {
                return null;
            }

            var paragraph = block.LastChild as ParagraphBlock;

            if (paragraph == null || paragraph.Inline == null)
            {
                return null;
            }

            var link = paragraph.Inline as LinkInline;

            if (link == null)
            {
                var container = paragraph.Inline as ContainerInline;

                if (container == null)
                {
                    return null;
                }

                link = container.FirstChild as LinkInline;

                if (link == null)
                {
                    return null;
                }
            }

            return ImportEntry(Path.Combine(currentPath.FullName, link.Url));
        }

        private RepositoryIndex ImportIndex(DirectoryInfo currentPath, MarkdownDocument document)
        {
            RepositoryIndex index = new RepositoryIndex();
            index.Name = currentPath.Name;

            foreach (var ii in document)
            {
                ListBlock list = ii as ListBlock;

                if (list != null)
                {
                    foreach (ListItemBlock jj in list)
                    {
                        var link = ImportIndexEntry(currentPath, jj);

                        if (link != null)
                        {
                            index.Children.Add(link);
                        }
                    }
                }
            }

            return index;
        }

        private class CellData
        {
            public string Text;
            public string Link;

            public static CellData Parse(ParagraphBlock paragraph)
            {
                CellData data = new CellData();

                StringBuilder buffer = new StringBuilder();

                foreach (var segment in paragraph.Inline)
                {
                    LinkInline link = segment as LinkInline;

                    if (link != null)
                    {
                        data.Link = link.Url;

                        buffer = new StringBuilder();

                        foreach (var text in link)
                        {
                            buffer.Append(text);
                        }

                        data.Text = buffer.ToString();
                        break;
                    }

                    buffer.Append(segment.ToString());
                }

                data.Text = buffer.ToString();
                return data;
            }
        }

        private class TableData
        {
            public List<string> Columns;
            public List<List<CellData>> Rows;

            public TableData()
            {
                Columns = new List<string>();
                Rows = new List<List<CellData>>();
            }

            public int Count
            { 
                get
                {
                    return Rows.Count;
                }
            }

            public CellData GetCell(string columnName, int index)
            {
                if (Rows.Count > index && index >= 0)
                {
                    var row = Rows[index];

                    for (int ii = 0; ii < row.Count && ii < Columns.Count; ii++)
                    {
                        if (Columns[ii] == columnName)
                        {
                            return row[ii];
                        }
                    }
                }

                return null;
            }
        }

        private Dictionary<string, CellData> ParseAttributeTable(Table table)
        {
            var attributes = new Dictionary<string, CellData>();

            bool body = false;

            foreach (TableRow row in table)
            {
                if (!body)
                {
                    body = true;
                    continue;
                }

                string name = null;
                CellData value = null;

                foreach (TableCell cell in row)
                {
                    foreach (var content in cell)
                    {
                        ParagraphBlock paragraph = content as ParagraphBlock;

                        if (paragraph != null)
                        {
                            var data = CellData.Parse(paragraph);

                            if (name == null)
                            {
                                name = data.Text;
                            }
                            else
                            {
                                value = data;
                            }
                        }
                    }
                }

                attributes[name] = value;
            }

            return attributes;
        }

        private TableData ParseGenericTable(Table table)
        {
            var data = new TableData();

            bool body = false;
            List<string> columns = new List<string>();
            List<List<CellData>> rows = new List<List<CellData>>();

            foreach (TableRow row in table)
            {
                if (!body)
                {
                    foreach (TableCell cell in row)
                    {
                        foreach (var content in cell)
                        {
                            ParagraphBlock paragraph = content as ParagraphBlock;

                            if (paragraph != null)
                            {
                                var cellData = CellData.Parse(paragraph);
                                columns.Add(cellData.Text);
                            }
                        }
                    }

                    body = true;
                    continue;
                }

                List<CellData> newRow = new List<CellData>();

                foreach (TableCell cell in row)
                {
                    foreach (var content in cell)
                    {
                        ParagraphBlock paragraph = content as ParagraphBlock;

                        if (paragraph != null)
                        {
                            var cellData = CellData.Parse(paragraph);
                            newRow.Add(cellData);
                        }
                    }
                }

                rows.Add(newRow);
            }

            data.Columns = columns;
            data.Rows = rows;

            return data;
        }

        private List<string> ReadDescription(MarkdownDocument document, ref int start)
        {
            List<string> descriptions = new List<string>();

            while (start < document.Count)
            {
                ParagraphBlock paragraph = document[start++] as ParagraphBlock;

                if (paragraph == null)
                {
                    break;
                }

                StringBuilder builder = new StringBuilder();

                foreach (var jj in paragraph.Inline)
                {
                    var linebreak = jj is Markdig.Syntax.Inlines.LineBreakInline;

                    if (linebreak)
                    {
                        descriptions.Add(builder.ToString());
                        builder.Length = 0;
                        continue;
                    }

                    builder.Append(jj.ToString());
                }

                descriptions.Add(builder.ToString());
            }

            return descriptions;
        }

        private Dictionary<string, List<string>> ReadReferenceDescription(MarkdownDocument document, ref int start)
        {
            Dictionary<string, List<string>> descriptions = new Dictionary<string, List<string>>();

            while (start < document.Count)
            {
                string name = null;
                var list = new List<string>();

                while (start < document.Count)
                {
                    HeadingBlock heading = document[start++] as HeadingBlock;

                    if (heading != null)
                    {
                        name = heading.Inline.FirstChild.ToString();
                        break;
                    }
                }

                list = ReadDescription(document, ref start);

                if (name != null)
                {
                    descriptions[name] = list;
                }
            }

            return descriptions;
        }

        private void UpdateReferences(TableData table, Dictionary<string, List<string>> descriptions, List<RepositoryReference> references)
        {
            for (int ii = 0; ii < table.Count; ii++)
            {
                var reference = new RepositoryReference();

                reference.BrowseName = null;
                reference.DataType = null;
                reference.Documentation = null;
                reference.ModellingRule = null;
                reference.NodeClass = NodeClass.Unspecified;
                reference.ReferenceType = null;
                reference.TypeDefinition = null;
                reference.ValueRank = ValueRanks.Scalar;

                var cell = table.GetCell("ReferenceType", ii);

                if (cell != null)
                {
                    reference.ReferenceType = new RepositoryLink()
                    {
                        Name = cell.Text,
                        Path = cell.Link
                    };
                }

                cell = table.GetCell("NodeClass", ii);

                if (cell != null && !String.IsNullOrEmpty(cell.Text))
                {
                    if (!Enum.TryParse<Opc.Ua.NodeClass>(cell.Text, out reference.NodeClass))
                    {
                        reference.NodeClass = Opc.Ua.NodeClass.Unspecified;
                    }
                }

                cell = table.GetCell("BrowseName", ii);

                if (cell != null && !String.IsNullOrEmpty(cell.Text))
                {
                    var name = cell.Text;
                    name = name.Replace("&lt;", "<");
                    name = name.Replace("&gt;", ">");
                    reference.BrowseName = name;
                }

                cell = table.GetCell("DataType", ii);

                if (cell != null && !String.IsNullOrEmpty(cell.Text))
                {
                    var dataType = cell.Text;

                    if (dataType.EndsWith("[]"))
                    {
                        reference.ValueRank = ValueRanks.OneDimension;
                        dataType = dataType.Substring(0, dataType.Length - 2);
                        dataType = dataType.Trim();
                    }

                    reference.DataType = new RepositoryLink()
                    {
                        Name = dataType,
                        Path = cell.Link
                    };
                }

                cell = table.GetCell("TypeDefinition", ii);

                if (cell != null && !String.IsNullOrEmpty(cell.Text))
                {
                    reference.TypeDefinition = new RepositoryLink()
                    {
                        Name = cell.Text,
                        Path = cell.Link
                    };
                }

                cell = table.GetCell("ModellingRule", ii);

                if (cell != null && !String.IsNullOrEmpty(cell.Text))
                {
                    reference.ModellingRule = new RepositoryLink()
                    {
                        Name = cell.Text,
                        Path = cell.Link
                    };
                }

                List<string> description = null;

                if (descriptions.TryGetValue(reference.BrowseName, out description))
                {
                    reference.Documentation = description;
                }

                references.Add(reference);
            }
        }

        private RepositoryObjectVariableType ImportObjectVariableType(MarkdownDocument document)
        {
            RepositoryObjectVariableType entry = new RepositoryObjectVariableType();

            TableData references = null;
            Dictionary<string, CellData> attributes = null;

            int start = 0;

            while (start < document.Count)
            {
                HeadingBlock heading = document[start++] as HeadingBlock;

                if (heading != null)
                {
                    entry.Name = heading.Inline.FirstChild.ToString();
                    break;
                }
            }

            entry.Documentation = ReadDescription(document, ref start);

            while (start < document.Count)
            {
                Table table = document[start++] as Table;

                if (table != null)
                {
                    attributes = ParseAttributeTable(table);
                    break;

                }
            }

            while (start < document.Count)
            {
                Table table = document[start++] as Table;

                if (table != null)
                {
                    references = ParseGenericTable(table);
                    break;

                }
            }

            while (start < document.Count)
            {
                Table table = document[start++] as Table;

                if (table != null)
                {
                    references = ParseGenericTable(table);
                    break;

                }
            }

            if (attributes != null)
            {
                entry.NodeClass = Opc.Ua.NodeClass.ObjectType;
                entry.IsAbstract = false;
                entry.BaseType = null;
                entry.DataType = null;
                entry.ValueRank = Opc.Ua.ValueRanks.Scalar;

                CellData cell = null;

                if (attributes.TryGetValue("BrowseName", out cell))
                {
                    var name = cell.Text;
                    name = name.Replace("&lt;", "<");
                    name = name.Replace("&gt;", ">");
                    entry.Name = name;
                }

                if (attributes.TryGetValue("NodeClass", out cell))
                {
                    if (!Enum.TryParse<Opc.Ua.NodeClass>(cell.Text, out entry.NodeClass))
                    {
                        entry.NodeClass = Opc.Ua.NodeClass.ObjectType;
                    }
                }

                if (attributes.TryGetValue("IsAbstract", out cell))
                {
                    if (!Boolean.TryParse(cell.Text, out entry.IsAbstract))
                    {
                        entry.IsAbstract = false;
                    }
                }

                if (attributes.TryGetValue("BaseType", out cell))
                {
                    entry.BaseType = new RepositoryLink()
                    {
                        Name = cell.Text,
                        Path = cell.Link
                    };
                }

                if (attributes.TryGetValue("DataType", out cell))
                {
                    entry.BaseType = new RepositoryLink()
                    {
                        Name = cell.Text,
                        Path = cell.Link
                    };
                }

                if (attributes.TryGetValue("ValueRank", out cell))
                {
                    if (!Int32.TryParse(cell.Text, out entry.ValueRank))
                    {
                        entry.ValueRank = Opc.Ua.ValueRanks.Scalar;
                    }
                }

                if (attributes.TryGetValue("Categories", out cell))
                {
                    var name = cell.Text;

                    if (!String.IsNullOrEmpty(name))
                    {
                        var categories = name.Split(',');

                        foreach (var category in categories)
                        {
                            //if (!String.IsNullOrEmpty(name) && !entry.Categories.Contains(category))
                            {
                                //entry.Categories.Add(category);
                            }
                        }
                    }
                }
            }

            if (references != null)
            {
                var descriptions = ReadReferenceDescription(document, ref start);
                UpdateReferences(references, descriptions, entry.References);
            }

            return entry;
        }

        private RepositoryDataType ImportDataType(MarkdownDocument document)
        {
            RepositoryDataType entry = new RepositoryDataType();

            TableData fields = null;
            TableData references = null;
            Dictionary<string, CellData> attributes = null;

            int start = 0;

            while (start < document.Count)
            {
                HeadingBlock heading = document[start++] as HeadingBlock;

                if (heading != null)
                {
                    entry.Name = heading.Inline.FirstChild.ToString();
                    break;
                }
            }

            entry.Documentation = ReadDescription(document, ref start);

            while (start < document.Count)
            {
                Table table = document[start++] as Table;

                if (table != null)
                {
                    fields = ParseGenericTable(table);
                    break;
                }
            }

            while (start < document.Count)
            {
                Table table = document[start++] as Table;

                if (table != null)
                {
                    attributes = ParseAttributeTable(table);
                    break;

                }
            }

            while (start < document.Count)
            {
                Table table = document[start++] as Table;

                if (table != null)
                {
                    references = ParseGenericTable(table);
                    break;

                }
            }

            if (attributes != null)
            {
                entry.IsAbstract = false;
                entry.BaseType = null;

                CellData cell = null;

                if (attributes.TryGetValue("BrowseName", out cell))
                {
                    entry.Name = cell.Text;
                }

                if (attributes.TryGetValue("IsAbstract", out cell))
                {
                    if (!Boolean.TryParse(cell.Text, out entry.IsAbstract))
                    {
                        entry.IsAbstract = false;
                    }
                }

                if (attributes.TryGetValue("BaseType", out cell))
                {
                    entry.BaseType = new RepositoryLink()
                    {
                        Name = cell.Text,
                        Path = cell.Link
                    };
                }
            }

            if (fields != null)
            {
                for (int ii = 0; ii < fields.Count; ii++)
                {
                    var field = new RepositoryDataTypeField();

                    field.Name = null;
                    field.DataType = null;
                    field.ValueRank = ValueRanks.Scalar;
                    field.Documentation = null;

                    var cell = fields.GetCell("Name", ii);

                    if (cell != null && !String.IsNullOrEmpty(cell.Text))
                    {
                        field.Name = cell.Text.Trim();

                        if (field.Name.StartsWith("&nbsp;"))
                        {
                            field.Name = field.Name.Replace("&nbsp;", "");
                            field.Name = field.Name.Substring(0, 1).ToUpper() + field.Name.Substring(1);
                        }
                    }

                    cell = fields.GetCell("Value", ii);

                    if (cell != null && !String.IsNullOrEmpty(cell.Text))
                    {
                        long value = 0;

                        if (Int64.TryParse(cell.Text, out value))
                        {
                            field.Value = (int)value;
                        }
                    }

                    cell = fields.GetCell("DataType", ii);

                    if (cell != null && !String.IsNullOrEmpty(cell.Text))
                    {
                        var dataType = cell.Text.Trim();

                        if (dataType.EndsWith("[]"))
                        {
                            field.ValueRank = ValueRanks.OneDimension;
                            dataType = dataType.Substring(0, dataType.Length - 2);
                            dataType = dataType.Trim();
                        }

                        field.DataType = new RepositoryLink()
                        {
                            Name = dataType,
                            Path = cell.Link
                        };
                    }

                    cell = fields.GetCell("Description", ii);

                    if (cell != null && !String.IsNullOrEmpty(cell.Text))
                    {
                        field.Documentation = new List<string>();
                        field.Documentation.Add(cell.Text);
                    }

                    if (ii != 0 || field.Name != entry.Name)
                    {
                        entry.Fields.Add(field);
                    }
                }
            }

            if (references != null)
            {
                var descriptions = ReadReferenceDescription(document, ref start);
                UpdateReferences(references, descriptions, entry.References);
            }

            return entry;
        }

        private RepositoryEntry ImportEntry(string path)
        {
            string filePath = path;

            if (!path.EndsWith(".md"))
            {
                filePath = Path.Combine(path, "readme.md");
            }

            if (!File.Exists(filePath))
            {
                return null;
            }

            string content = null;

            using (StreamReader reader = new StreamReader(filePath))
            {
                content = reader.ReadToEnd();
            }

            var pipeline = new MarkdownPipelineBuilder().UseAdvancedExtensions().Build();
            var document = Markdown.Parse(content, pipeline);

            var metadata = document.FirstOrDefault() as HtmlBlock;

            if (metadata.Type == HtmlBlockType.Comment)
            {
                switch (metadata.Lines.Lines[0].Slice.ToString())
                {
                    case "<!-- index -->":
                    {
                        return ImportIndex(new FileInfo(filePath).Directory, document);
                    }

                    case "<!-- objecttype -->":
                    {
                        return ImportObjectVariableType(document);
                    }

                    case "<!-- datatype -->":
                    {
                        return ImportDataType(document);
                    }
                }
            }

            return null;
        }

        public Repository Import(string path)
        {
            m_repository = new Repository();

            var entry = ImportEntry(path);

            var index = entry as RepositoryIndex;

            if (index != null)
            {
                m_repository.Children = index.Children;
            }
            else
            {
                m_repository.Children.Add(entry);
            }

            return m_repository;
        }
     }
}