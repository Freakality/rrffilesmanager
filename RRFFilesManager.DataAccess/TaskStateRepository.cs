using RRFFilesManager.Abstractions;
using RRFFilesManager.DataAccess.Abstractions;
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Text;


namespace RRFFilesManager.DataAccess
{
    public class TaskStateRepository : ITaskStateRepository
    {
        private readonly DataContext _context;
        public TaskStateRepository(DataContext context)
        {
            _context = context;
        }

        public TaskState GetById(int taskStateId)
        {
            var account = _context.TaskStates.FirstOrDefault(x => x.ID == taskStateId);

            return account;

        }

        public TaskState GetByDescription(string description)
        {
            var account = _context.TaskStates.FirstOrDefault(x => x.Description.ToLower() == description.ToLower());

            return account;

        }

        public void Insert(TaskState taskState)
        {
            _context.TaskStates.Add(taskState);

            _context.SaveChanges();
        }



        public IEnumerable<TaskState> List()
        {
            return _context.TaskStates.ToList(); ;
        }


        public void SoftDelete(int taskStateId)
        {
            var accountToDelete = _context.TaskStates.Find(taskStateId);

            _context.SaveChanges();

        }

        public void Update(TaskState taskState)
        {
            var trxTaskState = GetById(taskState.ID);
            _context.Entry(trxTaskState).CurrentValues.SetValues(taskState);
            _context.SaveChanges();

        }
    }
}
