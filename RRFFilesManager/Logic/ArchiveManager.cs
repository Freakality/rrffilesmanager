using RRFFilesManager.Abstractions;
using RRFFilesManager.DataAccess.Abstractions;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using RRFFilesManager.Utils;

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
        public Archive Update(Archive archive)
        {
            _archiveRepository.Update(archive);
            return archive;
        }


        public Archive Insert(Abstractions.File file, Archive archive, string fileName = null)
        {
            archive.CopyToFileFolder(fileName);
            _archiveRepository.Insert(file, archive);
            return archive;
        }
        public void Delete(Archive archive)
        {
            System.IO.File.Delete(archive.Path);
            _archiveRepository.Delete(archive);
        }
    }
}
