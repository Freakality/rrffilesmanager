using RRFFilesManager.Abstractions;
using RRFFilesManager.DataAccess.Abstractions;
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Text;

namespace RRFFilesManager.DataAccess
{
    public class LogItemRepository : ILogItemRepository
    {
        private readonly DataContext _context;
        public LogItemRepository(DataContext context)
        {
            _context = context;
        }

        public LogItem GetById(int logItemId)
        {
            var account = _context.LogItems.FirstOrDefault(x => x.ID == logItemId);
            return account;
        }

        public void Insert(LogItem logItem)
        {
            _context.LogItems.Add(logItem);
            _context.SaveChanges();
        }

        public IEnumerable<LogItem> List()
        {
            return _context.LogItems.ToList();
        }

        public void SoftDelete(int logItemId)
        {
            var accountToDelete = GetById(logItemId);
            _context.SaveChanges();
        }

        public void Update(LogItem logItem)
        {
            var trxFile = GetById(logItem.ID);
            _context.Entry(trxFile).CurrentValues.SetValues(logItem);
            _context.SaveChanges();
        }

        public IEnumerable<LogItem> Search(string searchText, DateTime dateLimit1, DateTime dateLimit2, int? take = null)
        {
            var query = _context.LogItems.Where(s =>
                (s.Date >= dateLimit1 &&
                s.Date <= dateLimit2) &&
                (s.Description.Contains(searchText) ||
                s.Lawyer.Description.ToString().Contains(searchText))
            );
            if (take != null)
            {
                query = query.Take(take.Value);
            }
            return query.ToList();
        }
    }
}
