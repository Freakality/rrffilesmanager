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
        IEnumerable<FileTask> Search(File file, TaskState taskState, int? take = null, Lawyer lawyer = null, TaskCategory businessProcess = null);
        void SwitchLawyer(Lawyer formerLawyer, Lawyer newLawyer);
        void AddTask(File file, Task task, TaskState taskState, int Days = 0, DateTime date = default);
        void AddAllCategoryTasks(File file, IEnumerable<Task> tasks, TaskState taskState, int Days = 0);
        bool DependencyStatusApproved(File file, Task task);
    }
}
