using RRFFilesManager.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RRFFilesManager.DataAccess.Abstractions
{
    public interface IFileStatusRepository
    {
        void Insert(FileStatus fileStatus);
        void Update(FileStatus fileStatus);
        void SoftDelete(int fileStatusId);
        FileStatus GetById(int fileStatusId);
        FileStatus GetByDescription(string fileStatusDescription);
        IEnumerable<FileStatus> List();
    }
}
