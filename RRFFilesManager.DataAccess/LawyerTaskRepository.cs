using RRFFilesManager.Abstractions;
using RRFFilesManager.DataAccess.Abstractions;
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Text;

namespace RRFFilesManager.DataAccess
{
    public class LawyerTaskRepository : ILawyerTaskRepository
    {
        private readonly DataContext _context;
        public LawyerTaskRepository(DataContext context)
        {
            _context = context;
        }

        public LawyerTask GetById(int lawyerTaskId)
        {
            var account = _context.LawyerTasks.FirstOrDefault(x => x.ID == lawyerTaskId);
            return account;
        }

        public void Insert(LawyerTask lawyerTask)
        {
            _context.LawyerTasks.Add(lawyerTask);
            _context.SaveChanges();
        }

        public IEnumerable<LawyerTask> List()
        {
            return _context.LawyerTasks.ToList(); ;
        }

        public void SoftDelete(int lawyerTaskId)
        {
            var accountToDelete = GetById(lawyerTaskId);
            _context.SaveChanges();
        }

        public void Update(LawyerTask lawyerTask)
        {
            var trxContact = GetById(lawyerTask.ID);
            _context.Entry(trxContact).CurrentValues.SetValues(lawyerTask);
            _context.SaveChanges();
        }

        public IEnumerable<LawyerTask> Search(Lawyer lawyer, TaskState taskState, int? take = null)
        {
            var query = _context.LawyerTasks.Where(s =>
                s.Lawyer == lawyer
            );
            if (taskState != null)
            {
                query = query.Where(s =>
                    s.State == taskState
                );
            }
            if (take != null)
            {
                query = query.Take(take.Value);
            }
            return query.ToList();
        }
    }
}
