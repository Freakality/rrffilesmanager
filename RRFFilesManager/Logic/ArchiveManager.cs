using RRFFilesManager.Abstractions;
using RRFFilesManager.DataAccess.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

        public Archive CreateAndAddArchive(File file, Template template = null)
        {
            var archive = _templateManager.CreateAndFillTemplate(file, template);
            _archiveRepository.Insert(file, archive);
            return archive;
        }

        public Archive UpdateArchive(Archive archive)
        {
            _templateManager.CreateAndFillTemplate(archive.File, archive.Template, archive);
            _archiveRepository.Update(archive);
            return archive;
        }
    }
}
