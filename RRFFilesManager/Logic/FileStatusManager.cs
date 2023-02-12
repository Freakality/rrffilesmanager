using Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Word;
using RRFFilesManager.Abstractions;
using RRFFilesManager.DataAccess.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RRFFilesManager.Logic
{
    public class FileStatusManager
    {
        private readonly IFileStatusRepository _fileStatusRepository;
       public  FileStatusManager()
        {
            _fileStatusRepository = Program.GetService<IFileStatusRepository>();
        }


        public IEnumerable<FileStatus> GetValidFileStatus(File file)
        {
            var fileStatus = _fileStatusRepository.List();
            List<FileStatus> result;
            switch (file.CurrentStatus.ID)
            {
                case (int)FileStatusEnum.PotentialFile:
                    result = fileStatus.Where(s => s.ID == (int)FileStatusEnum.OpenFile || s.ID == (int)FileStatusEnum.NotRetained).ToList();
                    break;
                case (int)FileStatusEnum.OpenFile:
                    result = fileStatus.Where(s => s.ID == (int)FileStatusEnum.ClosedFile).ToList();
                    break;
                case (int)FileStatusEnum.ClosedFile:
                    result = fileStatus.Where(s => s.ID == (int)FileStatusEnum.OpenFile).ToList();
                    break;
                case (int)FileStatusEnum.NotRetained:
                    result = Enumerable.Empty<FileStatus>().ToList();
                    break;
                default:
                    result = fileStatus.ToList();
                    break;
            }
            result.Add(file.CurrentStatus);
            return result;
        }

        

    }
}
