using RRFFilesManager.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace RRFFilesManager.DataAccess.Abstractions
{
    public interface IFileRepository
    {
        void Insert(File file);
        void Update(File file);
        void SoftDelete(int fileId);
        File GetById(int fileId);
        IEnumerable<File> List();
        IEnumerable<File> Search(string searchText, bool? hold = null, int? take = null);
        File GetLastFile(int? clientId = null);
        void AddFileContact(File file, Contact contact);
        void RemoveFileContact(File file, Contact contact);
        void AddTask(File file, Task task, TaskState taskState);
        void AddAllCategoryTasks(File file, IEnumerable<Task> tasks, TaskState taskState);
    }
}
