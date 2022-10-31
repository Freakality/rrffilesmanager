using RRFFilesManager.Abstractions;
using System;
using RRFFilesManager.Abstractions;
using RRFFilesManager.DataAccess.Abstractions;
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Text;

namespace RRFFilesManager.DataAccess.Abstractions
{
    public interface ITaskRepository
    {
        void Insert(Task task);
        void Update(Task task);
        void SoftDelete(int taskId);
        Task GetById(int taskId);
        IEnumerable<Task> List();
        IEnumerable<Task> Search(string searchText, int taskCategoryID, bool? hold = null, int? take = null);
        Task GetLastTask(int? categoryId = null);
        void AddTaskDependency(Task task, Task dependency);
        void RemoveTaskDependency(Task task, Task dependency);

    }
}
