using RRFFilesManager.Abstractions;
using RRFFilesManager.Logic;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RRFFilesManager.Utils
{
    public static class ExtensionMethods
    {
        public static string EscapeText(this string text)
        {
            string regexSearch = new string(System.IO.Path.GetInvalidFileNameChars()) + new string(System.IO.Path.GetInvalidPathChars());
            Regex r = new Regex(string.Format("[{0}]", Regex.Escape(regexSearch)));
            return r.Replace(text, "");
        }

        public static string GetFileFolderPath(this RRFFilesManager.Abstractions.File file)
        {
            if (file == null)
                throw new Exception("File can not be null");
            var clientFolderName = $"{file.Client.ID} - {file.Client.FirstName} {file.Client.LastName}";
            var path = Path.Combine(ConfigurationManager.AppSettings["FilesPath"], clientFolderName);
            path = Path.Combine(path, file.FileNumber.ToString());
            Directory.CreateDirectory(path);
            return path;
        }

        public static string GetNotRetainedFolderPath(this RRFFilesManager.Abstractions.File file)
        {
            if (file == null)
                throw new Exception("File can not be null");
            var clientFolderName = $"{file.Client.ID} - {file.Client.FirstName} {file.Client.LastName}";
            var path = Path.Combine(ConfigurationManager.AppSettings["FilesPath"], "Not Retained");
            path = Path.Combine(path, $"CYA - {file.MatterType.Description}");
            path = Path.Combine(path, clientFolderName);
            Directory.CreateDirectory(path);
            return path;
        }
        public static string GetArchiveFolderPath(this Archive archive)
        {
            if (archive.File == null)
                throw new Exception("File can not be null");
            string archiveFolderPath = null;
            // "Not Retained" file status Id
            if (archive.File.CurrentStatus?.ID == 4)
            {
                archiveFolderPath = archive.File.GetNotRetainedFolderPath();
            }
            else
            {
                archiveFolderPath = archive.File.GetFileFolderPath();
                if (!string.IsNullOrWhiteSpace(archive.File.CurrentStatus.Description))
                    archiveFolderPath = Path.Combine(archiveFolderPath, archive.File.CurrentStatus.Description.EscapeText());
            }
            Directory.CreateDirectory(archiveFolderPath);
            return archiveFolderPath;
        }
        public static void CopyToFileFolder(this Archive archive, string fileName = null)
        {
            var fileFolderPath = archive.GetArchiveFolderPath();
            if (!archive.Path.Contains(fileFolderPath))
            {
                var archiveFileName = fileName ?? System.IO.Path.GetFileName(archive.Path);
                var destFileName = Path.Combine(fileFolderPath, archiveFileName);
                System.IO.File.Copy(archive.Path, destFileName, true);
                archive.Path = destFileName;
                archive.Name = archiveFileName;
            }
        }

        public static string GetExtension(this Archive archive)
        {
            return Path.GetExtension(archive.Path);
        }

        public static void Open(this Archive archive)
        {
            var extension = archive.GetExtension();
            if ((new string[] { ".doc", ".docx" }).Contains(extension))
                Word.Open(archive.Path);
            else if ((new string[] { ".xls", ".xlsx" }).Contains(extension))
            {
                Excel.Open(archive.Path);
            }
            else
            {
                Word.Open(archive.Path);
            }
            
        }
    }
}
