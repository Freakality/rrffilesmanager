using RRFFilesManager.Abstractions;
using RRFFilesManager.DataAccess.Abstractions;
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Text;

namespace RRFFilesManager.DataAccess
{
    public class DenialBenefitRepository : IDenialBenefitRepository
    {
        private readonly DataContext _context;
        public DenialBenefitRepository(DataContext context)
        {
            _context = context;
        }

        public DenialBenefit GetById(int denialBenefitId)
        {
            var result = _context.DenialBenefits.FirstOrDefault(x => x.ID == denialBenefitId);
            return result;
        }

        public void Insert(DenialBenefit denialBenefit)
        {
            _context.DenialBenefits.Add(denialBenefit);
            _context.SaveChanges();
        }

        public IEnumerable<DenialBenefit> List()
        {
            return _context.DenialBenefits.ToList(); ;
        }

        public void SoftDelete(int denialBenefitId)
        {
            var accountToDelete = GetById(denialBenefitId);
            _context.SaveChanges();
        }

        public void Update(DenialBenefit denialBenefit)
        {
            var trxContact = GetById(denialBenefit.ID);
            _context.Entry(trxContact).CurrentValues.SetValues(denialBenefit);
            _context.SaveChanges();
        }

        public DenialBenefit GetByDescription(string description)
        {
            var result = _context.DenialBenefits.FirstOrDefault(x => x.Description == description);
            return result;
        }
    }
}
