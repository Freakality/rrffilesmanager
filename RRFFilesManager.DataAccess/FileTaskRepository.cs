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
            _context.Entry(trxContact).CurrentValues.SetValues(fileTask);
            _context.SaveChanges();
        }

        public IEnumerable<FileTask> Search(File file, TaskState taskState, int? take = null)
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
            if (take != null)
            {
                query = query.Take(take.Value);
            }
            return query.ToList();
        }
    }
}
