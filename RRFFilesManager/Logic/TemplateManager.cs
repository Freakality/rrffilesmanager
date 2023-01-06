using Microsoft.Office.Interop.Excel;
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
        public Archive CreateAndFillTemplate(Abstractions.File file, Abstractions.Template template, Archive archive = null)
        {
            if(template == null)
                return CreateAndFillTemplateWorkbook(file, archive);
            return CreateAndFillTemplateDocument(file, template, archive);
        }
        public Archive CreateAndFillTemplateDocument(Abstractions.File file, Abstractions.Template template, Archive archive = null)
        {
            var wordApp = new Microsoft.Office.Interop.Word.Application();
            wordApp.DisplayAlerts = WdAlertLevel.wdAlertsNone;
            var docuemntTemplatePath = GetDocumentTemplatePath(template.TemplatePath);
            if (!System.IO.File.Exists(docuemntTemplatePath))
                throw new Exception("File not found.");
            var document = wordApp?.Documents.Open(FileName: docuemntTemplatePath, ReadOnly: true);
            var fileName = $"{DateTime.Now:yyyyMMdd} {template.TemplateName}.doc";
            var filePath = GetDocumentFilePath(file.FileNumber, fileName);

            wordApp.Visible = false;
            Word.FillDocument(document, file);

            document.SaveAs(filePath);
            document.Close();
            wordApp.Quit();
            if (archive == null)
                archive = new Archive();
            archive.File = file;
            archive.Name = fileName;
            archive.Path = filePath;
            archive.Template = template;
            return archive;
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

        public string GetDocumentFilePath(int fileNumber, string fileName)
        {
            if (fileName == null)
                return null;
            var path = Path.Combine(ConfigurationManager.AppSettings["FilesPath"], fileNumber.ToString());
            Directory.CreateDirectory(path);
            return Path.Combine(path, fileName);
        }

        private Archive CreateAndFillTemplateWorkbook(Abstractions.File file, Archive archive = null)
        {
            var templatePath = GetWorkbookFilePath($"{file.MatterType.Description}.xlsx");
            var excelApp = new Microsoft.Office.Interop.Excel.Application();
            excelApp.DisplayAlerts = false;
            var workbook = excelApp?.Workbooks?.Open(templatePath);
            Worksheet worksheet = (Worksheet)workbook.Sheets[1];
            Excel.FillWorkSheet(worksheet, file);
            var filename = $"{DateTime.Now:yyyyMMddhhmmss}_MVAIntakeReport.xlsx";
            string filePath = GetWorkbookFilePath(filename);
            workbook.SaveAs(Filename: filePath);
            workbook.Close();
            excelApp.Quit();
            if (archive == null)
                archive = new Archive();
            archive.File = file;
            archive.Name = filename;
            archive.Path = filePath;
            return archive;
        }
        public string GetWorkbookFilePath(string fileName)
        {
            if (fileName == null)
                return null;
            return Path.Combine(ConfigurationManager.AppSettings["ExcelTemplatesPath"], fileName);
        }
        
    }
}
