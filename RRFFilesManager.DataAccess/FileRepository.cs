using RRFFilesManager.Abstractions;
using RRFFilesManager.DataAccess.Abstractions;
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Text;


namespace RRFFilesManager.DataAccess
{
    public class FileRepository : IFileRepository
    {
        private readonly DataContext _context;
        public FileRepository(DataContext context)
        {
            _context = context;
        }

        public File GetById(int fileId)
        {
            var account = _context.Files.FirstOrDefault(x => x.ID == fileId);
            return account;
        }

        public void Insert(File file)
        {
            _context.Files.Add(file);
            _context.SaveChanges();
        }

        public IEnumerable<File> List()
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
            _context.Entry(trxFile).CurrentValues.SetValues(file);
            _context.SaveChanges();
        }

        public IEnumerable<File> Search(string searchText, bool? hold = null, int? take = null)
        {
            var query = _context.Files.Where(s =>
                s.FileNumber.ToString().Contains(searchText) ||
                s.Client.FirstName.Contains(searchText) ||
                s.Client.LastName.Contains(searchText) ||
                s.Client.Email.Contains(searchText) ||
                s.MatterType.Description.Contains(searchText)
            );

            if (take != null)
                query = query.Take(take.Value);

            return query.ToList();
        }

        public File GetLastFile(int? clientId = null)
        {
            var query = _context.Files.OrderByDescending(s => s.ID);
            if (clientId != null)
                query = (IOrderedQueryable<File>)query.Where(s => s.Client != null && s.Client.ID == clientId.Value);
            return query.FirstOrDefault();
        }

        
    }
}
