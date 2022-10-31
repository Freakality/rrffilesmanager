using RRFFilesManager.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace RRFFilesManager.DataAccess.Abstractions
{
    public interface ITaskStateRepository
    {
        void Insert(TaskState taskState);
        void Update(TaskState taskState);
        void SoftDelete(int taskStateId);
        TaskState GetById(int taskStateId);
        TaskState GetByDescription(string description);
        IEnumerable<TaskState> List();
    }
}
