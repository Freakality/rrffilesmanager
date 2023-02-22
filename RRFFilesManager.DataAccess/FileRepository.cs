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

        public  IEnumerable<File> Search(string searchText, FileStatus fileStatus, bool? hold = null, int? take = null)
        {
            IQueryable<File> query = _context.Files;

            if (!string.IsNullOrWhiteSpace(searchText))
            {
                query = query.Where(s =>
                    s.FileNumber.ToString().Contains(searchText) ||
                    s.Client.FirstName.Contains(searchText) ||
                    s.Client.LastName.Contains(searchText) ||
                    s.Client.Email.Contains(searchText) ||
                    s.MatterType.Description.Contains(searchText)
                );
            } 
             
            if(fileStatus != null)
            {
                query = query.Where(s => s.CurrentStatus == fileStatus);
            }

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

        public bool DependencyStatusApproved(File file, Task task)
        {
            var exist = _context.FileTasks.Any(s => s.File.ID == file.ID && s.Task.ID == task.ID && s.State == _context.TaskStates.FirstOrDefault(x => x.Description.ToLower() == "done"));
            if (exist)
            {
                return true;
            }
            return false;
        }
        /*public void AddTask(File file, Task task, TaskState taskState, int Days)
        {
            var exist = _context.FileTasks.Any(s => s.File.ID == file.ID && s.Task.ID == task.ID);
            if (exist)
            {
                var fileTaskPrev = _context.FileTasks.Single(t => t.TaskId == task.ID && t.FileId == file.ID);
                var taskexisten = _context.FileTasks.Single(t => t.TaskId == task.ID && t.FileId == file.ID);
                taskexisten.DueDate = DateTime.Now;
                taskexisten.DeferUntilDate = DateTime.Now.AddDays(Days);
                _context.Entry(fileTaskPrev).CurrentValues.SetValues(taskexisten);
                _context.SaveChanges();
            }  
            else
            {
                
                if (task.Dependencies.Count > 0)
                {
                    foreach(TaskDependency taskDependency in task.Dependencies)
                    {
                        if (!DependencyStatusApproved(file, taskDependency.Dependency))
                        {
                            return;
                        }
                    }
                }
                var filetask = new FileTask
                {
                    File = file,
                    FileId = file.ID,
                    Task = task,
                    TaskId = task.ID,
                    DueDate = DateTime.Now,
                    DeferUntilDate = DateTime.Now.AddDays(Days),
                    State = taskState
                };
                _context.FileTasks.Add(filetask);
                _context.SaveChanges();
            }

            //if (exist)
            //    return;
            //DateTime dueDate;
            //DateTime deferUntil;
            //var fileTask = new FileTask
            //{
            //    File = file,
            //    FileId = file.ID,
            //    Task = task,
            //    TaskId = task.ID,
            //    DueDate = file.DateOfCall.AddDays(task.DueBy),
            //    DeferUntilDate = file.DateOfCall.AddDays(task.DeferBy),
            //    State = taskState
            //};

            //_context.FileTasks.Add(fileTask);
            //_context.SaveChanges(); 
        }

        public void AddAllCategoryTasks(File file, IEnumerable<Task> tasks, TaskState taskState,int Days)
        {
            foreach(Task task in tasks)
            {
                AddTask(file, task, taskState,Days);
            }
        }*/
    }
}
