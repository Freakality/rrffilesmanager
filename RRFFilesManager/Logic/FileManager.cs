using Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Word;
using RRFFilesManager.Abstractions;
using RRFFilesManager.DataAccess.Abstractions;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;


namespace RRFFilesManager.Logic
{
    public class FileManager
    {
        private readonly ArchiveManager _archiveManager;
        private readonly IFileRepository _fileRepository;
        FileManager()
        {
            _archiveManager = new ArchiveManager();
            _fileRepository = Program.GetService<IFileRepository>();
        }


        

    }
}
