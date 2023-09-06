using Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Word;
using RRFFilesManager.Abstractions;
using RRFFilesManager.DataAccess.Abstractions;
using RRFFilesManager.Utils;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;


namespace RRFFilesManager.Logic
{
    public class FileManager
    {
        private readonly ArchiveManager _archiveManager;
        private readonly IFileRepository _fileRepository;
        private readonly IFileStatusRepository _fileStatusRepository;
        public FileManager()
        {
            _archiveManager = new ArchiveManager();
            _fileRepository = Program.GetService<IFileRepository>();
            _fileStatusRepository = Program.GetService<IFileStatusRepository>();
        }

        public void SetCurrentFileStatus(File file, FileStatusEnum fileStatus)
        {
            file.CurrentStatus = _fileStatusRepository.GetById((int)fileStatus);
            Update(file);
        }

        public void Update(File file)
        {
            if(file.Archives != null)
            {
                foreach (var archive in file.Archives)
                {
                    archive.MoveToFileFolder();
                }
            }
            _fileRepository.Update(file);
        }

        public void UpdateUpload(File file)
        {
            if (file.Archives != null)
            {
                foreach (var archive in file.Archives)
                {
                    archive.CopyToFileFolder();
                }
            }
            _fileRepository.Update(file);
        }

        public void Insert(File file)
        {
            if (file.Archives != null)
            {
                foreach (var archive in file.Archives)
                {
                    archive.CopyToFileFolder();
                }
            }
            _fileRepository.Insert(file);
        }
    }
}