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

        public  IEnumerable<Archive> List(int? fileID = null, int? documentGroupID = null, int? documentCategoryID = null, int? documentTypeID = null)
        {
            var query = _context.Archives.AsQueryable();
            if (fileID != null)
                query = query.Where(s => s.File.ID == fileID.Value);
            if (documentGroupID != null)
                query = query.Where(s => s.DocumentGroup.ID == documentGroupID.Value);
            if (documentCategoryID != null)
                query = query.Where(s => s.DocumentCategory.ID == documentCategoryID.Value);
            if (documentTypeID != null)
                query = query.Where(s => s.DocumentType.ID == documentTypeID.Value);
            return query.ToList();
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
