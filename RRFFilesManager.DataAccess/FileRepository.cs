using RRFFilesManager.Abstractions;
using RRFFilesManager.DataAccess.Abstractions;
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.Data.Objects;
using System.Reflection;

namespace RRFFilesManager.DataAccess
{
    public class FileRepository : IFileRepository
    {
        private readonly DataContext _context;
        public FileRepository(DataContext context)
        {
            _context = context;
        }
        public  File GetById(int fileId)
        {
            var account = _context.Files.FirstOrDefault(x => x.ID == fileId);
            return account;
        }
        public void Insert(File file)
        {
            _context.Files.Add(file);
            _context.SaveChanges();
        }

        public  IEnumerable<File> List()
        {
            return _context.Files.ToList(); ;
        }

        public void SoftDelete(int fileId)
        {
            var accountToDelete = GetById(fileId);
            _context.SaveChanges();
        }

        public void Update(File file)
        {
            var trxFile = GetById(file.ID);
            if (file.CurrentStatus != trxFile.CurrentStatus)
            {
                file.DateOfStatusChange = DateTime.Now;
                file.PreviousStatus = trxFile.CurrentStatus;
            }
            _context.Entry(trxFile).CurrentValues.SetValues(file);
            _context.SaveChanges();
        }

        public  IEnumerable<File> Search(string searchText, bool? hold = null, int? take = null)
        {
            var query = _context.Files.Where(s =>
                s.FileNumber.ToString().Contains(searchText) ||
                s.Client.FirstName.Contains(searchText) ||
                s.Client.LastName.Contains(searchText) ||
                s.Client.Email.Contains(searchText) ||
                s.MatterType.Description.Contains(searchText)
            );

            if (take != null)
                query = query.Take(take.Value);

            return query.ToList();
        }

        public  File GetLastFile(int? clientId = null)
        {
            var query = _context.Files.OrderByDescending(s => s.ID);
            if (clientId != null)
                query = (IOrderedQueryable<File>)query.Where(s => s.Client != null && s.Client.ID == clientId.Value);
            return query.FirstOrDefault();
        }

        public void AddFileContact(File file, Contact contact)
        {
            var exist = _context.FileContacts.Any(s => s.File.ID == file.ID && s.Contact.ID == contact.ID);
            if (exist)
                return;
            var fileContact = new FileContact
            {
                File = file,
                FileId = file.ID,
                Contact = contact,
                ContactId = contact.ID
            };
            _context.FileContacts.Add(fileContact);
            _context.SaveChanges();
        }

        public void RemoveFileContact(File file, Contact contact)
        {
            var fileContact = _context.FileContacts.FirstOrDefault(s => s.File == file && s.Contact == contact);
            if (fileContact == null)
                return;
            _context.FileContacts.Remove(fileContact);
            _context.SaveChanges();
        }

        public void AddTask(File file, Task task, TaskState taskState)
        {
            var exist = _context.FileTasks.Any(s => s.File.ID == file.ID && s.Task.ID == task.ID);
            if (exist)
                return;
            DateTime dueDate;
            DateTime deferUntil;
            var fileTask = new FileTask
            {
                File = file,
                FileId = file.ID,
                Task = task,
                TaskId = task.ID,
                DueDate = file.DateOfCall.AddDays(task.DueBy),
                DeferUntilDate = file.DateOfCall.AddDays(task.DeferBy),
                State = taskState
            };
            _context.FileTasks.Add(fileTask);
            _context.SaveChanges(); 
        }

        public void AddAllCategoryTasks(File file, IEnumerable<Task> tasks, TaskState taskState)
        {
            foreach(Task task in tasks)
            {
                AddTask(file, task, taskState);
            }
        }
    }
}
