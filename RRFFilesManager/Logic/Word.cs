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

        public static void Open(string path)
        {
            var wordApp = new Application();
            wordApp.DisplayAlerts = WdAlertLevel.wdAlertsNone;
            var document = wordApp?.Documents.Open(FileName: path);
            wordApp.Visible = true;
        }

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
                ReplaceAll(document, "$$$MBIReport$$$", "");
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

        public static void FillDocumentABBReport(Document document, File file, IEnumerable<Archive> archives)
        {
            if (file == null || archives?.Count() == 0)
                return;
            FillDocument(document, file);
            Range range = document.Range(0, 0);
            if (range.Find.Execute("$$$ABBReport$$$"))
            {
                ReplaceAll(document, "$$$ABBReport$$$", "");
                int i = 0;
                foreach(var archive in archives)
                {
                    range.InsertAfter(archive.Name);
                    i++;
                    if(archives.Count() > i)
                        range.InsertAfter(Environment.NewLine);
                    
                }
            }
        }

        public static void FillDocumentPrescriptionsReport(Document document, File file, IEnumerable<OutOfPocketHealthCareExp> prescriptions)
        {
            if (file == null || prescriptions?.Count() == 0)
                return;
            FillDocument(document, file);
            Range range = document.Range(0, 0);
            if (range.Find.Execute("$$$PSROW$$$"))
            {
                ReplaceAll(document, "$$$PSROW$$$", "");
                var table = document.Tables[1];
                var line = 2;
                foreach (var prescription in prescriptions)
                {
                    line++;
                    if (line < prescriptions.Count() + 2)
                    table.Rows.Add(table.Rows[line]);
                    table.Cell(line, 1).Range.InsertAfter(prescription.RxFillDate.ToString("dddd, MMMM d, yyyy"));
                    table.Cell(line, 2).Range.InsertAfter(prescription.Pharmacy.Name);
                    if (prescription.ReturnKilometresTraveled != null)
                        table.Cell(line, 3).Range.InsertAfter(Math.Round(prescription.ReturnKilometresTraveled.Value, 2).ToString());
                    if(prescription.TravelExpenses != null)
                        table.Cell(line, 4).Range.InsertAfter(Math.Round(prescription.TravelExpenses.Value, 2).ToString());
                    if (prescription.ParkingExpenses != null)
                        table.Cell(line, 5).Range.InsertAfter(Math.Round(prescription.ParkingExpenses.Value, 2).ToString());
                    if (prescription.TreatmentExpenses != null)
                        table.Cell(line, 6).Range.InsertAfter(Math.Round(prescription.TreatmentExpenses.Value, 2).ToString());
                    if (prescription.MiscExpenses != null)
                        table.Cell(line, 7).Range.InsertAfter(Math.Round(prescription.MiscExpenses.Value, 2).ToString());
                }

                var totalReturnKilometresTraveled = prescriptions.Sum(s => s.ReturnKilometresTraveled ?? 0);
                var totalTravelExpenses = prescriptions.Sum(s => s.TravelExpenses ?? 0);
                var totalParkingExpenses = prescriptions.Sum(s => s.ParkingExpenses ?? 0);
                var totalTreatmentExpenses = prescriptions.Sum(s => s.TreatmentExpenses ?? 0);
                var totalMiscExpenses = prescriptions.Sum(s => s.MiscExpenses ?? 0);
                var total = totalTravelExpenses + totalParkingExpenses + totalTreatmentExpenses + totalMiscExpenses;
                ReplaceAll(document, "$$$PSTRKT$$$", Math.Round(totalReturnKilometresTraveled, 2).ToString());
                ReplaceAll(document, "$$$PSTE$$$", Math.Round(totalTravelExpenses, 2).ToString());
                ReplaceAll(document, "$$$PSTPE$$$", Math.Round(totalParkingExpenses, 2).ToString());
                ReplaceAll(document, "$$$PSTTE$$$", Math.Round(totalTreatmentExpenses, 2).ToString());
                ReplaceAll(document, "$$$PSTME$$$", Math.Round(totalMiscExpenses, 2).ToString());
                ReplaceAll(document, "$$$PST$$$", Math.Round(total, 2).ToString());

            }
        }
    }
}
