using RRFFilesManager.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RRFFilesManager.DataAccess.Abstractions
{
    public interface IFileTaskRepository
    {
        void Insert(FileTask fileTask);
        void Update(FileTask fileTask);
        void SoftDelete(int fileTaskId);
        FileTask GetById(int fileTaskId);
        IEnumerable<FileTask> List();
        IEnumerable<FileTask> Search(File file, TaskState taskState, int? take = null);
    }
}
