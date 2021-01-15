using Microsoft.Office.Interop.Word;
using RRFFilesManager.Abstractions;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RRFFilesManager.Logic
{
    public class TemplateManager
    {
        public Archive CreateAndFillTemplateDocument(Abstractions.File file, Abstractions.Template template)
        {
            var wordApp = new Microsoft.Office.Interop.Word.Application();
            wordApp.DisplayAlerts = WdAlertLevel.wdAlertsNone;
            var docuemntTemplatePath = GetDocumentTemplatePath(template.TemplatePath);
            if (!System.IO.File.Exists(docuemntTemplatePath))
                throw new Exception("File not found.");
            var document = wordApp?.Documents.Open(FileName: docuemntTemplatePath, ReadOnly: true);
            var fileName = $"{DateTime.Now:yyyyMMddhhmmss}_{template.TemplateName}.doc";
            var filePath = GetFilePath(file.FileNumber, fileName);

            wordApp.Visible = false;
            Word.ReplaceAll(document, "$$$TodaysDate$$$", DateTime.Now.ToString("MMMM d, yyyy"));
            Word.ReplaceAll(document, "$$$FirstName$$$", file.Client?.FirstName);
            Word.ReplaceAll(document, "$$$LastName$$$", file.Client?.LastName);
            Word.ReplaceAll(document, "$$$Address1$$$", file.Client?.Address);
            Word.ReplaceAll(document, "$$$Address2$$$", "");
            Word.ReplaceAll(document, "$$$City$$$", file.Client?.City);
            Word.ReplaceAll(document, "$$$Province$$$", file.Client?.Province?.Description);
            Word.ReplaceAll(document, "$$$PostalCode$$$", file.Client?.PostalCode);
            Word.ReplaceAll(document, "$$$Salutation$$$", file.Client?.Salutation);
            Word.ReplaceAll(document, "$$$E-mail$$$", file.Client?.Email);
            Word.ReplaceAll(document, "$$$DateOfLoss$$$", file.DateOFLoss.ToString("MMMM d, yyyy"));
            Word.ReplaceAll(document, "$$$FileNumber$$$", file.FileNumber.ToString());
            while (document.Content.Find.Execute(FindText: "  ", Wrap: WdFindWrap.wdFindContinue))
            {
                Word.ReplaceAll(document, "  ", " ");
            }

            document.SaveAs(filePath);
            document.Close();
            wordApp.Quit();
            return new Archive() { 
               File = file,
               Name = fileName,
               Path = filePath,
               Template = template
            };
        } 
        public string GetDocumentTemplatePath(string templateDocumentPath)
        {
            if (string.IsNullOrWhiteSpace(templateDocumentPath))
                throw new Exception("File path not found.");
            string wordTemplatesPathSetting = ConfigurationManager.AppSettings["WordTemplatesPath"];

            if (!string.IsNullOrWhiteSpace(wordTemplatesPathSetting))
                templateDocumentPath = templateDocumentPath.Replace(@"\\FS\FOISY\!", wordTemplatesPathSetting);
            return templateDocumentPath;
        }

        public string GetFilePath(int fileNumber, string fileName)
        {
            if (fileName == null)
                return null;
            var path = Path.Combine(ConfigurationManager.AppSettings["ExcelTemplatesPath"], fileNumber.ToString());
            Directory.CreateDirectory(path);
            return Path.Combine(path, fileName);
        }
    }
}
