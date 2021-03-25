using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Text;
using RRFFilesManager.Abstractions;
using RRFFilesManager.DataAccess;
using RRFFilesManager.DataAccess.Abstractions;

namespace RRFFilesManager.DataAccess
{
    public class ArchiveRepository : IArchiveRepository
    {
        private readonly DataContext _context;
        public ArchiveRepository(DataContext context)
        {
            _context = context;
        }

        public  Archive GetById(int archiveId)
        {
            var account = _context.Archives.FirstOrDefault(x => x.ID == archiveId);
            return account;
        }

        public void Insert(File file, Archive archive)
        {
            archive.File = file;
            _context.Archives.Add(archive);
            _context.SaveChanges();
        }

        public  IEnumerable<Archive> List()
        {
            return _context.Archives.ToList(); ;
        }

        public void SoftDelete(int archiveId)
        {
            var accountToDelete = GetById(archiveId);
            _context.SaveChanges();
        }

        public void Delete(Archive archive)
        {
            var trxArchive = GetById(archive.ID);
            _context.Archives.Remove(trxArchive);
            _context.SaveChanges();
        }

        public void Update(Archive archive)
        {
            var trxArchive = GetById(archive.ID);
            _context.Entry(trxArchive).CurrentValues.SetValues(archive);
            _context.SaveChanges();
        }
        
    }
}
