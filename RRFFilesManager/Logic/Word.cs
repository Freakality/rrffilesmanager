using Microsoft.Office.Interop.Word;
using RRFFilesManager.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace RRFFilesManager.Logic
{
    public class Word
    {

        public static void ReplaceAll(Document document, string findText, string replaceWith)
        {
            if(string.IsNullOrWhiteSpace(replaceWith))
                document.Content.Find.Execute(FindText: $"^p{findText}", ReplaceWith: replaceWith, Replace: WdReplace.wdReplaceAll);
            document.Content.Find.Execute(FindText: findText, ReplaceWith: replaceWith, Replace: WdReplace.wdReplaceAll);
        }

        public static void FillDocument(Document document, File file)
        {
            ReplaceAll(document, "$$$TodaysDate$$$", DateTime.Now.ToString("MMMM d, yyyy"));
            ReplaceAll(document, "$$$FirstName$$$", file.Client?.FirstName.ToUpper());
            ReplaceAll(document, "$$$LastName$$$", file.Client?.LastName.ToUpper());
            ReplaceAll(document, "$$$Address1$$$", file.Client?.AddressLine1);
            ReplaceAll(document, "$$$Address2$$$", file.Client?.AddressLine2);
            ReplaceAll(document, "$$$City$$$", file.Client?.City);
            ReplaceAll(document, "$$$Province$$$", file.Client?.Province?.Description);
            ReplaceAll(document, "$$$PostalCode$$$", file.Client?.PostalCode);
            ReplaceAll(document, "$$$Salutation$$$", file.Client?.Salutation);
            ReplaceAll(document, "$$$E-mail$$$", file.Client?.Email);
            ReplaceAll(document, "$$$DateOfLoss$$$", file.DateOFLoss.ToString("MMMM d, yyyy"));
            ReplaceAll(document, "$$$FileNumber$$$", file.FileNumber.ToString());
        }

        public static void FillDocumentMBIReport(Document document, File file, IEnumerable<Archive> archives)
        {
            if (file == null || archives?.Count() == 0)
                return;
            FillDocument(document, file);
            Range range = document.Range(0, 0);
            if (range.Find.Execute("$$$MBIReport$$$"))
            {
                var indexCategories = archives.Select(s => s.DocumentType.IndexCategory).Distinct();
                document.Tables.Add(range, archives.Count() + indexCategories.Count(), 3);
                var table = document.Tables[1];
                table.AllowAutoFit = true;
                table.Columns[1].Width = (float)48.26;
                table.Columns[2].Width = (float)319.05;
                table.Columns[3].Width = (float)135.4;

                var line = 1;
                var archivesReport = archives.Where(s => s.DocumentType.IndexCategory == "Reports");
                var archivesClinicalNotes = archives.Where(s => s.DocumentType.IndexCategory == "Clinical Notes and Records");
                if (archivesReport.Count() > 0)
                {
                    
                    FillTable(table, ref line, archivesReport, "#", "Reports", "Date", i => $"T{i + 1}.");
                    if (archivesClinicalNotes.Count() > 0)
                    {
                        table.Cell(line, 2).Range.InsertAfter(Environment.NewLine);
                        table.Cell(line, 2).Range.InsertAfter(Environment.NewLine);
                        line++;
                    }
                }
                if(archivesClinicalNotes.Count() > 0)
                {
                    FillTable(table, ref line, archivesClinicalNotes, null, "Clinical Notes", null, i => $"{GetLetter(i)}.");
                }
            }
        }

        private static void FillTable(Table table, ref int line, IEnumerable<Archive> archives, string header1, string header2, string header3, Func<int, string> numerator)
        {
            if(header1 != null)
                table.Cell(line, 1).Range.InsertAfter(header1);
            if (header2 != null)
            {
                table.Cell(line, 2).Range.InsertAfter(header2);
                table.Cell(line, 2).Range.InsertAfter(Environment.NewLine);
            }
            if (header3 != null)
                table.Cell(line, 3).Range.InsertAfter(header3);
            table.Rows[line].Range.Bold = 500;
            table.Rows[line].Range.Underline = WdUnderline.wdUnderlineSingle;
            var i = 0;
            foreach (var archive in archives)
            {
                line++;
                table.Rows[line].Range.Bold = 0;
                table.Cell(line, 1).Range.InsertAfter(numerator.Invoke(i));
                var archiveName = System.IO.Path.GetFileNameWithoutExtension(archive.Name);
                table.Cell(line, 2).Range.InsertAfter(archiveName);
                table.Cell(line, 2).Range.InsertAfter(Environment.NewLine);
                table.Cell(line, 3).Range.InsertAfter(archive.Created.ToString("MMMM d, yyyy"));
                i++;
            }
        }
        private static string GetLetter(int i)
        {
            return ((char)(i + 65)).ToString();
        }
    }
}
