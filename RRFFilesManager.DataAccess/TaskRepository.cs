using RRFFilesManager.Abstractions;
using RRFFilesManager.DataAccess.Abstractions;
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Text;

namespace RRFFilesManager.DataAccess
{
    public class TaskRepository : ITaskRepository
    {
        private readonly DataContext _context;
        public TaskRepository(DataContext context)
        {
            _context = context;
        }

        public Task GetById(int taskId)
        {
            var account = _context.Tasks.FirstOrDefault(x => x.ID == taskId);
            return account;
        }
        public Task GetByTaskIdNumber(string taskIdNumber)
        {
            var account = _context.Tasks.FirstOrDefault(x => x.TaskIDNumber == taskIdNumber);
            return account;
        }

        public void Insert(Task task)
        {
            _context.Tasks.Add(task);
            _context.SaveChanges();
        }

        public IEnumerable<Task> List()
        {
            return _context.Tasks.ToList(); ;
        }

        public void SoftDelete(int taskId)
        {
            var accountToDelete = GetById(taskId);
            _context.SaveChanges();
        }

        public void Update(Task task)
        {
            var trxFile = GetById(task.ID);
            _context.Entry(trxFile).CurrentValues.SetValues(task);
            _context.SaveChanges();
        }

        public IEnumerable<Task> Search(string searchText, int taskCategoryID = -1, bool? hold = null, int? take = null)
        {
            int min = 0;
            int max = 0;
            if (taskCategoryID == -1)
            {
                min = -1;
                max = Int32.MaxValue;
            }
            else
            {
                min = taskCategoryID - 1;
                max = taskCategoryID + 1;
            }
            IQueryable<Task> query;
            if (String.IsNullOrEmpty(searchText))
            {
                query = _context.Tasks.Where(s =>
                (s.TaskCategory.ID > min &&
                s.TaskCategory.ID < max)
                );
            }
            else
            {
                query = _context.Tasks.Where(s =>
                    (s.Description.Contains(searchText) ||
                    s.Lawyer.Description.Contains(searchText) ||
                    s.TaskCategory.Description.Contains(searchText)) &&
                    (s.TaskCategory.ID > min &&
                    s.TaskCategory.ID < max)
                );

            }

            if (take != null)
                query = query.Take(take.Value);

            return query.ToList();
        }

        public Task GetLastTask(int? categoryId = null)
        {
            var query = _context.Tasks.OrderByDescending(s => s.ID);
            if (categoryId != null)
                query = (IOrderedQueryable<Task>)query.Where(s => s.TaskCategory != null && s.TaskCategory.ID == categoryId.Value);
            return query.FirstOrDefault();
        }

        public void AddTaskDependency(Task task, Task dependency)
        {
            var exist = _context.TaskDependencies.Any(s => s.Task.ID == task.ID && s.Dependency.ID == dependency.ID);
            if (exist)
                return;
            var taskDependency = new TaskDependency
            {
                Task = task,
                TaskId = task.ID,
                Dependency = dependency,
                DependencyId = dependency.ID
            };
            _context.TaskDependencies.Add(taskDependency);
            _context.SaveChanges();
        }

        public void RemoveTaskDependency(Task task, Task dependency)
        {
            var taskDependency = _context.TaskDependencies.FirstOrDefault(s => s.Task == task && s.Dependency == dependency);
            if (taskDependency == null)
                return;
            _context.TaskDependencies.Remove(taskDependency);
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
                Lawyer = task.Lawyer,
                State = taskState
            };
            _context.FileTasks.Add(fileTask);
            _context.SaveChanges();
        }

        public void SwitchLawyer(Lawyer formerLawyer, Lawyer newLawyer)
        {
            IQueryable<Task> query = _context.Tasks.Where(s =>
                s.Lawyer == formerLawyer
            );
            var taskList = query.ToList();
            taskList.ForEach(a =>
            {
                a.Lawyer = newLawyer;
            });
            _context.SaveChanges();
        }
    }
}
