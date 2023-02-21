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
using System.Windows.Forms;

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
            if (archive.File.CurrentStatus?.ID == (int)FileStatusEnum.NotRetained)
            {
                archiveFolderPath = archive.File.GetNotRetainedFolderPath();
            }
            else
            {
                archiveFolderPath = archive.File.GetFileFolderPath();
                if (!string.IsNullOrWhiteSpace(archive.File.CurrentStatus?.Description))
                    archiveFolderPath = Path.Combine(archiveFolderPath, archive.File.CurrentStatus.Description.EscapeText());
            }
            Directory.CreateDirectory(archiveFolderPath);
            return archiveFolderPath;
        }
        public static void CopyToFileFolder(this Archive archive, string fileName = null)
        {
            var fileFolderPath = archive.GetArchiveFolderPath();
            var sourcePath = archive.Path;
            if (!sourcePath.Contains(fileFolderPath))
            {
                var archiveFileName = fileName ?? Path.GetFileName(archive.Path);
                var destPath = Path.Combine(fileFolderPath, archiveFileName);
                if (System.IO.File.Exists(sourcePath))
                {
                    System.IO.File.Copy(sourcePath, destPath, true);
                }
                else
                {
                    sourcePath = GetFileNameFromUser(sourcePath);
                    if (sourcePath != null)
                    {
                        System.IO.File.Copy(sourcePath, destPath, true);
                    }
                }

                if (sourcePath != null)
                {
                    archive.Path = destPath;
                    archive.Name = archiveFileName;
                }
            }
        }

        public static void MoveToFileFolder(this Archive archive, string fileName = null)
        {
            var fileFolderPath = archive.GetArchiveFolderPath();
            var sourcePath = archive.Path;
            if (!sourcePath.Contains(fileFolderPath))
            {
                var archiveFileName = fileName ?? Path.GetFileName(archive.Path);
                var destPath = Path.Combine(fileFolderPath, archiveFileName);
                if(System.IO.File.Exists(sourcePath))
                {
                    try
                    {
                        System.IO.File.Move(sourcePath, destPath);
                    } catch(Exception e)
                    {
                        Console.WriteLine(e);
                    }
                    
                }
                else
                {
                    sourcePath = GetFileNameFromUser(sourcePath);
                    if (sourcePath != null)
                    {
                        System.IO.File.Copy(sourcePath, destPath, true);
                    }
                }

                if (sourcePath != null)
                {
                    archive.Path = destPath;
                    archive.Name = archiveFileName;
                }
            }
        }

        public static string GetFileNameFromUser(string sourcePath)
        {
            var result = MessageBox.Show(
                        $"File not found: {sourcePath}.\n" +
                        $"Do you want to manually find the location of the file?\n" +
                        "Select \"Yes\" to manually browse the file location or \"No\" to skip.",
                        "File not found",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    );
            if (result == DialogResult.Yes)
            {
                var newSourceFileName = GetFileNameFromFindFileDialog();
                return newSourceFileName;
            }
            return null;
        }
        public static string GetFileNameFromFindFileDialog()
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK) // Test result.
            {
                return openFileDialog1.FileName;
            }
            return null;
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
