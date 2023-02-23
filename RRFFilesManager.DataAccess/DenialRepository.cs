using RRFFilesManager.Abstractions;
using RRFFilesManager.DataAccess.Abstractions;
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Text;

namespace RRFFilesManager.DataAccess
{
    public class DenialRepository : IDenialRepository
    {
        private readonly DataContext _context;
        public DenialRepository(DataContext context)
        {
            _context = context;
        }

        public Denial GetById(int denialId)
        {
            var account = _context.Denials.FirstOrDefault(x => x.ID == denialId);
            return account;
        }

        public void Insert(Denial denial, File file)
        {
            denial.File = file;
            _context.Denials.Add(denial);
            _context.SaveChanges();
        }

        public IEnumerable<Denial> List()
        {
            return _context.Denials.ToList(); ;
        }

        public void SoftDelete(int denialId)
        {
            var accountToDelete = GetById(denialId);
            _context.SaveChanges();
        }

        public void Update(Denial denial)
        {
            var trxFile = GetById(denial.ID);
            _context.Entry(trxFile).CurrentValues.SetValues(denial) ;
            _context.SaveChanges();
        }

        public IEnumerable<Denial> Search(File file, DenialBenefit denialBenefit = null, DenialStatus denialStatus = null, int? take = null)
        {
            var query = _context.Denials.Where(s =>
                s.File.ID == file.ID 
            );
            if (denialBenefit != null)
            {
                query = query.Where(s =>
                    s.DenialBenefit == denialBenefit
                );

            }
            if (denialStatus != null)
            {
                query = query.Where(s =>
                    s.DenialStatus == denialStatus
                );
            }
            if (take != null)
                query = query.Take(take.Value);

            return query.ToList();
        }
    }
}
