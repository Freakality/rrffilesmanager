using RRFFilesManager.Abstractions;
using RRFFilesManager.DataAccess.Abstractions;
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Text;

namespace RRFFilesManager.DataAccess
{
    public class FileTaskRepository : IFileTaskRepository
    {
        private readonly DataContext _context;
        public FileTaskRepository(DataContext context)
        {
            _context = context;
        }

        public FileTask GetById(int fileTaskId)
        {
            var account = _context.FileTasks.FirstOrDefault(x => x.ID == fileTaskId);
            return account;
        }

        public void Insert(FileTask fileTask)
        {
            _context.FileTasks.Add(fileTask);
            _context.SaveChanges();
        }

        public IEnumerable<FileTask> List()
        {
            return _context.FileTasks.ToList(); ;
        }

        public void SoftDelete(int fileTaskId)
        {
            var accountToDelete = GetById(fileTaskId);
            _context.SaveChanges();
        }
        public void Update(FileTask fileTask)
        {
            var trxContact = GetById(fileTask.ID);
            if (trxContact.State == _context.TaskStates.FirstOrDefault(x => x.Description.ToLower() == "to do") && 
                fileTask.State == _context.TaskStates.FirstOrDefault(x => x.Description.ToLower() == "done"))
            {
                foreach(TaskDependency taskDependency in fileTask.Task.Dependencies)
                {
                    AddTask(fileTask.File, taskDependency.Task, _context.TaskStates.FirstOrDefault(x => x.Description.ToLower() == "to do"), 0);
                }
            }
            _context.Entry(trxContact).CurrentValues.SetValues(fileTask);
            _context.SaveChanges();
        }
        public IEnumerable<FileTask> Search(File file, TaskState taskState = null, int? take = null, Lawyer lawyer = null, TaskCategory businessProcess = null)
        {
            var query = _context.FileTasks.Where(s =>
                s.File == file
            );
            if (taskState != null)
            {
                query = query.Where(s =>
                    s.State == taskState
                );
            }

            if (lawyer != null)
            {
                query = query.Where(s =>
                    s.Lawyer.ID == lawyer.ID
                );
            }

            if (businessProcess != null)
            {
                query = query.Where(s =>
                    s.Task.TaskCategory.ID == businessProcess.ID
                );
            }

            if (take != null)
            {
                query = query.Take(take.Value);
            }
            return query.ToList();
        }
        public void SwitchLawyer(Lawyer formerLawyer, Lawyer newLawyer)
        {
            IQueryable<FileTask> query = _context.FileTasks.Where(s =>
                s.Lawyer == formerLawyer &&
                s.State.Description == "To Do"
            );
            var taskList = query.ToList();
            taskList.ForEach(a =>
            {
                a.Lawyer = newLawyer;
            });
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
        public void AddTask(File file, Task task, TaskState taskState, int Days, DateTime date = default)
        {
            int due = task.DueBy;
            DateTime newDueDate = DateTime.Now;
            if (date != default)
            {
                newDueDate = date;
                //Days = -120;
            }
            if (Days != 0)
            {
                due = Days;
            }
            var exist = _context.FileTasks.Any(s => s.File.ID == file.ID && s.Task.ID == task.ID);
            if (exist)
            {
                var fileTaskPrev = _context.FileTasks.Single(t => t.TaskId == task.ID && t.FileId == file.ID);
                var taskexisten = _context.FileTasks.Single(t => t.TaskId == task.ID && t.FileId == file.ID);
                taskexisten.DueDate = newDueDate.AddDays(due);
                taskexisten.DeferUntilDate = DateTime.Now.AddDays(task.DeferBy);
                _context.Entry(fileTaskPrev).CurrentValues.SetValues(taskexisten);
                _context.SaveChanges();
            }
            else
            {
                /*if (task.Dependencies.Count > 0)
                {
                    foreach (TaskDependency taskDependency in task.Dependencies)
                    {
                        if (!DependencyStatusApproved(file, taskDependency.Dependency))
                        {
                            return;
                        }
                    }
                }*/
                
                var filetask = new FileTask
                {
                    File = file,
                    FileId = file.ID,
                    Task = task,
                    TaskId = task.ID,
                    DueDate = newDueDate.AddDays(due),
                    DeferUntilDate = DateTime.Now.AddDays(task.DeferBy),
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
        public void AddAllCategoryTasks(File file, IEnumerable<Task> tasks, TaskState taskState, int Days = 0)
        {
            foreach(Task task in tasks)
            {
                AddTask(file, task, taskState, Days);
            }
        }
    }
}
