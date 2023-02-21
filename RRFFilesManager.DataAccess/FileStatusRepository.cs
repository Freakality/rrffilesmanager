using RRFFilesManager.Abstractions;
using RRFFilesManager.DataAccess.Abstractions;
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Text;

namespace RRFFilesManager.DataAccess
{
    public class FileStatusRepository : IFileStatusRepository
    {
        private readonly DataContext _context;
        public FileStatusRepository(DataContext context)
        {
            _context = context;
        }

        public FileStatus GetById(int fileStatusId)
        {
            var result = _context.FileStatus.FirstOrDefault(x => x.ID == fileStatusId);
            return result;
        }
        public FileStatus GetByDescription(string fileStatusDescription)
        {
            var result = _context.FileStatus.FirstOrDefault(x => x.Description == fileStatusDescription);
            return result;
        }

        public void Insert(FileStatus fileTask)
        {
            _context.FileStatus.Add(fileTask);
            _context.SaveChanges();
        }

        public IEnumerable<FileStatus> List()
        {
            return _context.FileStatus.ToList(); ;
        }

        public void SoftDelete(int fileStatusId)
        {
            var accountToDelete = GetById(fileStatusId);
            _context.SaveChanges();
        }

        public void Update(FileStatus fileTask)
        {
            var trxContact = GetById(fileTask.ID);
            _context.Entry(trxContact).CurrentValues.SetValues(fileTask);
            _context.SaveChanges();
        }
    }
}
