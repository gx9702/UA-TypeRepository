using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Forms=System.Windows.Forms;
using Microsoft.Office.Interop.Word;

namespace MarkdownProcessor
{
    class WordImporter
    {
        private Range m_content;
        private SectionType m_sectionType = SectionType.Normal;
        private Dictionary<string, string> m_headings = new Dictionary<string, string>();
        private Dictionary<string, Term> m_terms = new Dictionary<string, Term>();

        public class TableData
        {
            public string Title;
            public List<string> Headings;
            public List<List<string>> Rows;

            public void AddHeading(Cell cell)
            {
                if (Headings == null)
                {
                    Headings = new List<string>();
                }

                var text = cell.Range.Text.Trim();

                while (text.EndsWith("\a"))
                {
                    text = text.Substring(0, text.Length - 1);
                }

                Headings.Add(text);
            }

            public void SetCell(int row, int column, Cell cell)
            {
                if (Rows == null)
                {
                    Rows = new List<List<string>>();
                }

                while (Rows.Count < row + 1)
                {
                    Rows.Add(new List<string>());
                }

                var columns = Rows[row];

                while (columns.Count < column + 1)
                {
                    columns.Add(null);
                }

                var text = cell.Range.Text.Trim();

                while (text.EndsWith("\a"))
                {
                    text = text.Substring(0, text.Length - 1);
                }

                columns[column] = text;
            }
        }

        public class Term
        {
            public string Name;
            public string Section;
            public string Context;
            public int RefCount;
        };

        public enum LinkType
        {
            Section,
            Figure,
            Table,
            Note,
            Bookmark,
            Property
        };

        public class Link
        {
            public LinkType Type;
            public string Target;
        };

        public enum SectionType
        {
            Normal,
            Definitions,
            Abbreviations,
            References
        }

        private void IndexHeadings(Document document)
        {
            Array references = (Array)(object)document.GetCrossReferenceItems(WdReferenceType.wdRefTypeHeading);

            foreach (string reference in references)
            {
                var ii = reference.Trim();
                int index = ii.IndexOf(' ');

                if (index > 0)
                {
                    var name = ii.Substring(0, index);
                    m_headings[name] = ii.Substring(index + 1);
                }
            }
        }

        private List<Link> CollectLinks(Range range)
        {
            List<Link> links = new List<Link>();

            foreach (Field ii in range.Fields)
            {
                if (ii.Type == WdFieldType.wdFieldRef)
                {
                    links.Add(new Link()
                    {
                        Type = LinkType.Section,
                        Target = ii.Result.Text.Trim()
                    });
                }
                else if (ii.Type == WdFieldType.wdFieldSequence)
                {
                    if (ii.Code.Text.Contains("SEQ Figure"))
                    {
                        links.Add(new Link()
                        {
                            Type = LinkType.Figure,
                            Target = ii.Result.Text.Trim()
                        });
                    }
                    else if (ii.Code.Text.Contains("SEQ Table"))
                    {
                        links.Add(new Link()
                        {
                            Type = LinkType.Table,
                            Target = ii.Result.Text.Trim()
                        });
                    }
                    else if (ii.Code.Text.Contains("SEQ note"))
                    {
                        links.Add(new Link()
                        {
                            Type = LinkType.Note,
                            Target = ii.Result.Text.Trim()
                        });
                    }
                    else
                    {
                        links.Add(new Link()
                        {
                            Type = LinkType.Section,
                            Target = ii.Result.Text.Trim()
                        });
                    }
                }
                else
                {
                    links.Add(new Link()
                    {
                        Type = LinkType.Section,
                        Target = ii.Result.Text.Trim()
                    });
                }
            }

            return links;
        }

        private int FindFirstSection(Document document)
        {
            foreach (Paragraph paragraph in document.Content.Paragraphs)
            {
                Style style = paragraph.get_Style();

                if (paragraph.OutlineLevel == WdOutlineLevel.wdOutlineLevel1)
                {
                    if (style.NameLocal.Contains("Heading 1"))
                    {
                        return paragraph.Range.Start;
                    }
                }
            }

            return document.Content.End;
        }

        private string FindSection(Range range)
        {
            if (range.Paragraphs.Count == 0)
            {
                return "<not found>";
            }

            return FindSection(range.Paragraphs[1]);
        }

        private string FindSection(Paragraph paragraph)
        {
            var target = paragraph;

            while (m_content.Start <= target.Range.Start)
            {
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

            return "<not found>";
        }

        private string FindContext(Range range, int start, int end, int count)
        {
            if (range.Paragraphs.Count == 0)
            {
                return "<not found>";
            }

            Paragraph ii = range.Paragraphs[1];

            string prefix = "";

            if (start - ii.Range.Start > count)
            {
                start -= count;
                prefix = "...";
            }
            else
            {
                start = ii.Range.Start;
            }

            while (ii.Range.End < end)
            {
                ii = ii.Next(1);
            }

            string suffix = "";

            if (ii.Range.End - end > count)
            {
                end += count;
                suffix = "...";
            }
            else
            {
                end = ii.Range.End - 1;
            }

            range = range.Document.Range(start, end);

            return $"{prefix}{range.Text}{suffix}";
        }

        private List<string> CollectTerms(Range range)
        {
            var terms = new List<string>();

            if (String.IsNullOrWhiteSpace(range.Text))
            {
                return terms;
            }

            var section = FindSection(range);

            var buffer = new StringBuilder();

            foreach (Range ii in range.Characters)
            {
                if (ii.Italic != 0)
                {
                    buffer.Append(ii.Text);
                    continue;
                }

                if (buffer.Length > 0)
                {
                    var tokens = buffer.ToString().Trim().Split(new char[] { ' ', '\t', ',', '.', ':', ';', '(', ')', '\'', '"', '\u201C', '\u201D', '\u2018', '\u2019' }, StringSplitOptions.RemoveEmptyEntries);

                    foreach (var token in tokens)
                    {
                        if (token.Length < 4)
                        {
                            continue;
                        }

                        Term term = null;

                        if (!m_terms.TryGetValue(token, out term))
                        {
                            term = new Term()
                            {
                                Name = token,
                                Section = section,
                                Context = FindContext(range, ii.Start, ii.End, 40)
                            };

                            m_terms[token] = term;
                        }

                        term.RefCount++;
                    }

                    buffer.Length = 0;
                }
            }

            return terms;
        }

        private void CopyHeading(Document output, Paragraph input, string styleName)
        {
            // p.Range.ListFormat.ListString;

            // select end of document.
            Section section = output.Sections[output.Sections.Count];
            Range range = output.Range(section.Range.End - 1);

            Paragraph newParagraph = output.Paragraphs.Add(range);
            range.set_Style(styleName);
            newParagraph.Range.Text = input.Range.Text;

            switch (input.Range.Text.Trim())
            {
                case "Normative references": { m_sectionType = SectionType.References; break; }
                case "Terms and definitions": { m_sectionType = SectionType.Definitions; break; }
                case "Abbreviations and symbols": { m_sectionType = SectionType.Abbreviations; break; }

                default:
                    {
                        if (newParagraph.OutlineLevel <= WdOutlineLevel.wdOutlineLevel2)
                        {
                            m_sectionType = SectionType.Normal;
                            break;
                        }

                        break;
                    }
            }
        }

        private void UpdateParagraph(Document document, Paragraph paragraph, string text, List<string> terms, List<Link> links)
        {
            Range range = paragraph.Range;

            // remove control charaters and whitespace.
            while (text[text.Length - 1] == '\a')
            {
                text = text.Substring(0, text.Length - 1);
            }

            text = text.Trim();

            if (String.IsNullOrEmpty(text))
            {
                return;
            }

            // inserting new text appears to insert before rather than update the range of the current paragraph.
            range.Text = text;

            int offset = 0;

            foreach (string ii in terms)
            {
                int index = range.Text.IndexOf(ii, offset);

                if (index >= 0)
                {
                    Range wordRange = document.Range(range.Start + index, range.Start + index + ii.Length);
                    wordRange.Italic = -1;
                    offset = index + ii.Length + 1;
                }
            }

            offset = 0;

            foreach (var ii in links)
            {
                var heading = ii.Target;
                int index = range.Text.IndexOf(heading, offset);

                if (index >= 0)
                {
                    string headingText = heading;

                    if (ii.Type == LinkType.Section)
                    {
                        if (!m_headings.TryGetValue(heading, out headingText))
                        {
                            headingText = heading;
                        }
                    }

                    Range wordRange = document.Range(range.Start + index, range.Start + index + heading.Length);
                    wordRange.Text = $"[{headingText}]";
                    offset = index + headingText.Length + 1;
                }
            }
        }

        private int CopyParagraph(Document output, Paragraph input, string styleName)
        {
            // select end of document.
            Section section = output.Sections[output.Sections.Count];
            Range range = output.Range(section.Range.End - 1);
            Paragraph newParagraph = null;

            var links = CollectLinks(input.Range);
            var terms = CollectTerms(input.Range);

            if (links.Count > 0 && links[0].Type == LinkType.Figure)
            {
                newParagraph = output.Paragraphs.Add(range);

                var text = input.Range.Text.Trim();

                string prefix = null;
                string number = $"{links[0].Target}";

                int index = text.IndexOf(number);

                if (index >= 0)
                {
                    prefix = text.Substring(0, index);
                    text = text.Substring(index + number.Length + 1);
                }

                range.InsertCaption(WdCaptionLabelID.wdCaptionFigure, $" {text}", ExcludeLabel: false);
                range.set_Style("FIGURE-title");
                range.InsertParagraphAfter();

                Range titleRange = range.Words[2];
                titleRange.Text = prefix;

                return input.Range.End;
            }

            foreach (InlineShape ii in input.Range.InlineShapes)
            {
                newParagraph = output.Paragraphs.Add(range);
                var previous = newParagraph.Previous(1).Range.Text;
                range.set_Style(styleName);

                if (ii.Type == WdInlineShapeType.wdInlineShapeEmbeddedOLEObject)
                {
                    ii.Range.Copy();
                    newParagraph.Range.Paste();
                }
                else
                {
                    Range shapeRange = input.Range.Document.Range(ii.Range.Start - 1, ii.Range.End);
                    shapeRange.Copy();
                    newParagraph.Range.Paste();
                }

                newParagraph.Range.set_Style("FIGURE");
                output.Range(output.Content.End - 1).Copy();

                return input.Range.End;
            }

            if (links.Count > 0 && links[0].Type == LinkType.Table)
            {
                var text = input.Range.Text.Trim();

                string prefix = null;
                string number = $"{links[0].Target}";

                int index = text.IndexOf(number);

                if (index >= 0)
                {
                    prefix = text.Substring(0, index);
                    text = text.Substring(index + number.Length + 1);
                }

                TableData data = new TableData();
                data.Title = text;

                range.InsertCaption(WdCaptionLabelID.wdCaptionTable, $" {text}", ExcludeLabel: false);
                range.set_Style("TABLE-title");

                Range titleRange = range.Words[1];
                titleRange.Text = prefix;

                input = input.Next(1);

                while (input.Range.Tables.Count == 0)
                {
                    input = input.Next(1);
                }

                range = output.Range(range.End - 1);
                range.set_Style("No Spacing");

                foreach (Table table in input.Range.Tables)
                {
                    Table newTable = output.Tables.Add(range, table.Rows.Count, table.Columns.Count);

                    newTable.Borders[WdBorderType.wdBorderRight].LineStyle = WdLineStyle.wdLineStyleSingle;
                    newTable.Borders[WdBorderType.wdBorderLeft].LineStyle = WdLineStyle.wdLineStyleSingle;
                    newTable.Borders[WdBorderType.wdBorderTop].LineStyle = WdLineStyle.wdLineStyleSingle;
                    newTable.Borders[WdBorderType.wdBorderBottom].LineStyle = WdLineStyle.wdLineStyleSingle;
                    newTable.Borders[WdBorderType.wdBorderHorizontal].LineStyle = WdLineStyle.wdLineStyleSingle;
                    newTable.Borders[WdBorderType.wdBorderVertical].LineStyle = WdLineStyle.wdLineStyleSingle;

                    for (int ii = 1; ii <= table.Rows.Count; ii++)
                    {
                        var row = table.Rows[ii];
                        var newRow = newTable.Rows[ii];

                        if (ii == 1)
                        {
                            newRow.Borders[WdBorderType.wdBorderBottom].LineStyle = WdLineStyle.wdLineStyleDouble;
                        }

                        for (int jj = 1; jj <= table.Columns.Count; jj++)
                        {
                            if (jj <= row.Cells.Count)
                            {
                                Cell cell = row.Cells[jj];
                                var newCell = newRow.Cells[jj];

                                links = CollectLinks(cell.Range);
                                terms = CollectTerms(cell.Range);

                                Paragraph contents = output.Paragraphs.Add(newCell.Range);
                                UpdateParagraph(output, contents, cell.Range.Text, terms, links);

                                if (ii == 1)
                                {
                                    data.AddHeading(cell);
                                    cell.Range.Bold = -1;
                                }
                                else
                                {
                                    data.SetCell(ii - 1, jj - 1, cell);
                                }
                            }
                            else
                            {
                                var newCell = newRow.Cells[jj];
                                Paragraph contents = output.Paragraphs.Add(newCell.Range);
                            }
                        }

                        for (int jj = newRow.Cells.Count; jj > row.Cells.Count; jj--)
                        {
                            newRow.Cells[jj - 1].Merge(newRow.Cells[jj]);
                        }

                        string cellStyle = (ii == 1) ? "TABLE-col-heading" : "TABLE-cell";

                        for (int jj = 1; jj <= newRow.Cells.Count; jj++)
                        {
                            string cellText = newRow.Cells[jj].Range.Text;

                            for (int kk = cellText.Length - 1; kk >= 0; kk--)
                            {
                                if (cellText[kk] == '\a')
                                {
                                    continue;
                                }

                                if (cellText[kk] != '\r')
                                {
                                    cellText = cellText.Substring(0, kk + 1);
                                    cellText += '\a';
                                    break;
                                }

                                if (kk == 0)
                                {
                                    cellText = "\a";
                                    break;
                                }
                            }

                            newRow.Cells[jj].Range.Text = cellText;
                            newRow.Cells[jj].Range.set_Style(cellStyle);
                        }
                    }

                    range = output.Range(section.Range.End - 1);
                    newParagraph = output.Paragraphs.Add(range);
                    range.set_Style("No Spacing");

                    Paragraph next = input.Next(1);

                    while (next.Range.End <= table.Range.End)
                    {
                        next = next.Next(1);
                    }

                    return next.Range.End;
                }
            }

            newParagraph = output.Paragraphs.Add(range);
            UpdateParagraph(output, newParagraph, input.Range.Text, terms, links);
            range.set_Style(styleName);

            if (String.IsNullOrWhiteSpace(input.Range.Text))
            {
                return input.Range.End;
            }

            int offset = 0;

            foreach (Bookmark ii in input.Range.Bookmarks)
            {
                var name = ii.Name;
                var text = ii.Range.Text;

                int index = newParagraph.Range.Text.IndexOf(text, offset);

                if (index >= 0)
                {
                    Range wordRange = output.Range(newParagraph.Range.Start + index, newParagraph.Range.Start + index + text.Length);
                    range.Bookmarks.Add(name, wordRange);
                    range.set_Style("ReferenceText");
                }
            }

            Style priorStyle = newParagraph.Previous(1).get_Style();

            if (priorStyle.NameLocal == "ReferenceText")
            {
                range.set_Style("ReferenceLink");
            }

            if (input.Range.ListFormat.ListType == WdListType.wdListBullet)
            {
                if (priorStyle.NameLocal == "TERM-note")
                {
                    range.set_Style("TERM-note");
                }

                range.ListFormat.ApplyBulletDefault();
            }

            if (m_sectionType == SectionType.Abbreviations)
            {
                range.set_Style("PARAGRAPH-Compressed");
            }

            range.InsertParagraphAfter();

            return input.Range.End;
        }

        private void AuditTerms(Document document, string outputFile)
        {
            FileInfo file = new FileInfo(outputFile);

            List<string> terms = new List<string>(m_terms.Keys);
            terms.Sort();

            using (StreamWriter writer = new StreamWriter(Path.Combine(file.DirectoryName, "Terms.csv"), false, new UTF8Encoding(true)))
            {
                writer.WriteLine($"Term,References,Section,Context");

                foreach (var ii in terms)
                {
                    Term term = null;

                    if (m_terms.TryGetValue(ii, out term))
                    {
                        writer.WriteLine($"{term.Name},{term.RefCount},\"{term.Section}\",\"{term.Context}\"");
                    }
                }
            }
        }

        private bool IsAppendix(Paragraph paragraph)
        {
            Style currentStyle = paragraph.Range.get_Style();

            if (currentStyle.NameLocal.StartsWith("Appendix", StringComparison.InvariantCultureIgnoreCase) || currentStyle.NameLocal.StartsWith("ANNEX", StringComparison.InvariantCultureIgnoreCase))
            {
                return true;
            }

            return false;
        }

        public void Analyze(string inputFile, string templateFile, string outputFile)
        {
            Application word = null;
            Document input = null;
            Document output = null;

            try
            {
                word = new Application { Visible = false };

                word.Documents.Open(inputFile, true);
                word.Documents.Open(templateFile, true);

                input = word.Documents[inputFile];
                output = word.Documents[templateFile];
                output.ShowSpellingErrors = false;

                IndexHeadings(input);

                Section section = output.Sections[1];
                Range target = output.Range(section.Range.End - 1);
                bool firstHeadingFound = false;

                int start = FindFirstSection(input);
                int end = 0;
                int count = 0;

                m_content = input.Range(start, input.Content.End - 1);

                foreach (Paragraph paragraph in m_content.Paragraphs)
                {
                    if (count++ % 64 == 0)
                    {
                        Console.WriteLine();
                        Console.Write($"{paragraph.Range.End}/{input.Content.End} ");
                    }
                    else
                    {
                        Console.Write(".");
                    }

                    if (count > 30000)
                    {
                        break;
                    }

                    if (paragraph.Range.End <= end)
                    {
                        continue;
                    }

                    string styleName = "PARAGRAPH";
                    Style currentStyle = paragraph.Range.get_Style();

                    switch (paragraph.OutlineLevel)
                    {
                        case WdOutlineLevel.wdOutlineLevel1:
                        {
                            if (IsAppendix(paragraph))
                            {
                                styleName = "ANNEX_title";
                            }
                            else
                            {
                                styleName = "Heading 1";
                            }

                            firstHeadingFound = true;
                            break;
                        }

                        case WdOutlineLevel.wdOutlineLevel2:
                        {
                            if (IsAppendix(paragraph))
                            {
                                styleName = "ANNEX-heading1";
                            }
                            else
                            {
                                styleName = "Heading 2";
                            }

                            break;
                        }

                        case WdOutlineLevel.wdOutlineLevel3:
                        {
                            if (IsAppendix(paragraph))
                            {
                                styleName = "ANNEX-heading2";
                            }
                            else
                            {
                                styleName = "Heading 3";
                            }

                            break;
                        }

                        case WdOutlineLevel.wdOutlineLevel4:
                        {
                            if (IsAppendix(paragraph))
                            {
                                styleName = "ANNEX-heading3";
                            }
                            else
                            {
                                styleName = "Heading 4";
                            }

                            break;
                        }

                        default:
                        {
                            if (currentStyle.NameLocal.StartsWith("ANNEX_title"))
                            {
                                styleName = "ANNEX_title";
                            }

                            if (currentStyle.NameLocal.StartsWith("TERM"))
                            {
                                styleName = currentStyle.NameLocal;
                            }

                            if (paragraph.Range.Font.Name.Contains("Courier"))
                            {
                                styleName = "CODE";
                            }

                            break;
                        }
                    }

                    if (!firstHeadingFound)
                    {
                        continue;
                    }

                    if (paragraph.OutlineLevel != WdOutlineLevel.wdOutlineLevelBodyText)
                    {
                        CopyHeading(output, paragraph, styleName);
                        continue;
                    }

                    end = CopyParagraph(output, paragraph, styleName);
                }

                output.SaveAs2(outputFile);

                AuditTerms(input, outputFile);
            }
            finally
            {
                if (input != null)
                {
                    input.Close(false);
                }

                if (output != null)
                {
                    output.Close(false);
                }

                if (word != null)
                {
                    word.Quit();
                }
            }
        }
    }
}
