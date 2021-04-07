using RRFFilesManager.Abstractions;
using RRFFilesManager.DataAccess.Abstractions;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RRFFilesManager.Logic
{
    public class ArchiveManager
    {
        private readonly IArchiveRepository _archiveRepository;
        private readonly TemplateManager _templateManager;
        public ArchiveManager()
        {
            _archiveRepository = Program.GetService<IArchiveRepository>();
            _templateManager = new TemplateManager();
        }

        public Archive CreateAndAddArchiveFromTemplate(Abstractions.File file, Template template = null)
        {
            var archive = _templateManager.CreateAndFillTemplate(file, template);
            _archiveRepository.Insert(file, archive);
            return archive;
        }

        public Archive UpdateArchiveFromTemplate(Archive archive)
        {
            _templateManager.CreateAndFillTemplate(archive.File, archive.Template, archive);
            _archiveRepository.Update(archive);
            return archive;
        }

        public Archive Insert(Abstractions.File file, Archive archive, string fileName = null)
        {
            CopyArchiveToFileFolder(file, archive, fileName);
            _archiveRepository.Insert(file, archive);
            return archive;
        }
        public void Delete(Archive archive)
        {
            System.IO.File.Delete(archive.Path);
            _archiveRepository.Delete(archive);
        }

        public void CopyArchiveToFileFolder(Abstractions.File file, Archive archive, string fileName = null)
        {
            var fileFolderPath = GetArchiveFolderPath(file, archive);
            if (!archive.Path.Contains(fileFolderPath))
            {
                var archiveFileName = fileName ?? System.IO.Path.GetFileName(archive.Path);
                var destFileName = System.IO.Path.Combine(fileFolderPath, archiveFileName);
                System.IO.File.Copy(archive.Path, destFileName, true);
                archive.Path = destFileName;
                archive.Name = archiveFileName;
            }
        }

        private string GetArchiveFolderPath(Abstractions.File file, Archive archive)
        {
            
            if (file == null)
                throw new Exception("File can not be null");
            var archiveFolderPath = GetFileFolderPath(file);
            if (!string.IsNullOrWhiteSpace(archive.DocumentGroup?.Description))
                archiveFolderPath = System.IO.Path.Combine(archiveFolderPath, EscapeText(archive.DocumentGroup.Description));
            if (!string.IsNullOrWhiteSpace(archive.DocumentCategory?.Description))
                archiveFolderPath = System.IO.Path.Combine(archiveFolderPath, EscapeText(archive.DocumentCategory.Description));
            System.IO.Directory.CreateDirectory(archiveFolderPath);
            return archiveFolderPath;
        }

        public string EscapeText(string text)
        {
            string regexSearch = new string(System.IO.Path.GetInvalidFileNameChars()) + new string(System.IO.Path.GetInvalidPathChars());
            Regex r = new Regex(string.Format("[{0}]", Regex.Escape(regexSearch)));
            return r.Replace(text, "");
        }

        private string GetFileFolderPath(Abstractions.File file)
        {
            if (file == null)
                throw new Exception("File can not be null");
            var path = System.IO.Path.Combine(ConfigurationManager.AppSettings["FilesPath"], file.FileNumber.ToString());
            System.IO.Directory.CreateDirectory(path);
            return path;
        }
    }
}
