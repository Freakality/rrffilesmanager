using RRFFilesManager.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RRFFilesManager.DataAccess.Abstractions
{
    public interface ITaskCategoryRepository
    {
        void Insert(TaskCategory taskCategory);
        void Update(TaskCategory taskCategory);
        void SoftDelete(int taskCategoryId);
        TaskCategory GetById(int taskCategoryId);
        IEnumerable<TaskCategory> List();
        IEnumerable<TaskCategory> Search(string searchText, bool? hold = null, int? take = null);
    }
}
