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

        private void StatusCheck(string fileStatusDescription)
        {
            if (_fileStatusRepository.GetByDescription(fileStatusDescription) is null)
            {
                FileStatus status = new FileStatus();
                status.Description = fileStatusDescription;
                _fileStatusRepository.Insert(status);
            }
        }
        private void FillStatus()
        {
            StatusCheck("Potential File");
            StatusCheck("Open File");
            StatusCheck("Closed Files");
            StatusCheck("Not Retained");
        }
        public IEnumerable<FileStatus> GetValidFileStatus(File file)
        {
            FillStatus();
            var fileStatus = _fileStatusRepository.List();
            List<FileStatus> result;
            if (file.CurrentStatus is null)
            {
                file.CurrentStatus = _fileStatusRepository.GetByDescription("Potential File");
            }
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
