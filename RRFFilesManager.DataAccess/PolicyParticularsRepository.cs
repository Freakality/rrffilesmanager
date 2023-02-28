using RRFFilesManager.Abstractions;
using RRFFilesManager.DataAccess.Abstractions;
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Text;

namespace RRFFilesManager.DataAccess
{
    public class PolicyParticularsRepository : IPolicyParticularsRepository
    {
        private readonly DataContext _context;
        public PolicyParticularsRepository(DataContext context)
        {
            _context = context;
        }

        public PolicyParticulars GetById(int policyParticularsId)
        {
            var account = _context.PolicyParticulars.FirstOrDefault(x => x.ID == policyParticularsId);
            return account;
        }

        public void Insert(PolicyParticulars policyParticulars, File file)
        {
            policyParticulars.File = file;
            _context.PolicyParticulars.Add(policyParticulars);
            _context.SaveChanges();
        }

        public IEnumerable<PolicyParticulars> List()
        {
            return _context.PolicyParticulars.ToList(); ;
        }

        public void SoftDelete(int policyParticularsId)
        {
            var accountToDelete = GetById(policyParticularsId);
            _context.SaveChanges();
        }

        public void Update(PolicyParticulars policyParticulars)
        {
            var trxFile = GetById(policyParticulars.ID);
            _context.Entry(trxFile).CurrentValues.SetValues(policyParticulars) ;
            _context.SaveChanges();
        }

        public IEnumerable<PolicyParticulars> Search(File file, int? take = null)
        {
            var query = _context.PolicyParticulars.Where(s =>
                s.File.ID == file.ID 
            );
            if (take != null)
                query = query.Take(take.Value);

            return query.ToList();
        }
    }
}
