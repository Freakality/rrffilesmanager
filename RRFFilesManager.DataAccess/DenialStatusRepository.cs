using RRFFilesManager.Abstractions;
using RRFFilesManager.DataAccess.Abstractions;
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Text;

namespace RRFFilesManager.DataAccess
{
    public class DenialStatusRepository : IDenialStatusRepository
    {
        private readonly DataContext _context;
        public DenialStatusRepository(DataContext context)
        {
            _context = context;
        }

        public DenialStatus GetById(int denialStatusId)
        {
            var result = _context.DenialStatus.FirstOrDefault(x => x.ID == denialStatusId);
            return result;
        }

        public void Insert(DenialStatus denialStatus)
        {
            _context.DenialStatus.Add(denialStatus);
            _context.SaveChanges();
        }

        public IEnumerable<DenialStatus> List()
        {
            return _context.DenialStatus.ToList(); ;
        }

        public void SoftDelete(int denialStatusId)
        {
            var accountToDelete = GetById(denialStatusId);
            _context.SaveChanges();
        }

        public void Update(DenialStatus denialStatus)
        {
            var trxContact = GetById(denialStatus.ID);
            _context.Entry(trxContact).CurrentValues.SetValues(denialStatus);
            _context.SaveChanges();
        }

        public DenialStatus GetByDescription(string description)
        {
            var result = _context.DenialStatus.FirstOrDefault(x => x.Description == description);
            return result;
        }
    }
}
