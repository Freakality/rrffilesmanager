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

        public static string GetFolderPath(this RRFFilesManager.Abstractions.File file)
        {
            if (file == null)
                throw new Exception("File can not be null");
            var path = System.IO.Path.Combine(ConfigurationManager.AppSettings["FilesPath"], file.FileNumber.ToString());
            System.IO.Directory.CreateDirectory(path);
            return path;
        }
        public static string GetFolderPath(this Archive archive)
        {

            if (archive.File == null)
                throw new Exception("File can not be null");
            var archiveFolderPath = archive.File.GetFolderPath();
            if (!string.IsNullOrWhiteSpace(archive.DocumentGroup?.Description))
                archiveFolderPath = System.IO.Path.Combine(archiveFolderPath, archive.DocumentGroup.Description.EscapeText());
            if (!string.IsNullOrWhiteSpace(archive.DocumentCategory?.Description))
                archiveFolderPath = System.IO.Path.Combine(archiveFolderPath, archive.DocumentCategory.Description.EscapeText());
            System.IO.Directory.CreateDirectory(archiveFolderPath);
            return archiveFolderPath;
        }
        public static void CopyToFileFolder(this Archive archive, string fileName = null)
        {
            var fileFolderPath = archive.GetFolderPath();
            if (!archive.Path.Contains(fileFolderPath))
            {
                var archiveFileName = fileName ?? System.IO.Path.GetFileName(archive.Path);
                var destFileName = System.IO.Path.Combine(fileFolderPath, archiveFileName);
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
