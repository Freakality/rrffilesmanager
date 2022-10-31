using RRFFilesManager.Abstractions;
using RRFFilesManager.DataAccess.Abstractions;
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Text;

namespace RRFFilesManager.DataAccess
{
    public class TaskCategoryRepository : ITaskCategoryRepository
    {
        private readonly DataContext _context;
        public TaskCategoryRepository(DataContext context)
        {
            _context = context;
        }

        public TaskCategory GetById(int taskCategoryId)
        {
            var taskCategory = _context.TaskCategories.FirstOrDefault(x => x.ID == taskCategoryId);

            return taskCategory;

        }

        public void Insert(TaskCategory taskCategory)
        {
            _context.TaskCategories.Add(taskCategory);

            _context.SaveChanges();
        }



        public IEnumerable<TaskCategory> List()
        {
            var taskCategories = _context.TaskCategories.ToList();
            return taskCategories;
        }


        public void SoftDelete(int taskCategoryId)
        {
            var accountToDelete = _context.TaskCategories.Find(taskCategoryId);

            _context.SaveChanges();

        }

        public void Update(TaskCategory taskCategory)
        {
            var trxTaskCategory = GetById(taskCategory.ID);
            _context.Entry(trxTaskCategory).CurrentValues.SetValues(taskCategory);
            _context.SaveChanges();

        }

        public IEnumerable<TaskCategory> Search(string searchText, bool? hold = null, int? take = null)
        {
            var query = _context.TaskCategories.Where(s =>
                (s.Description.Equals(searchText))

            );

            if (take != null)
                query = query.Take(take.Value);

            return query.ToList();
        }
    }
}
