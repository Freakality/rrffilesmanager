using RRFFilesManager.Abstractions;
using RRFFilesManager.DataAccess.Abstractions;
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Text;


namespace RRFFilesManager.DataAccess
{
    public class DisabilityInsuranceCompanyRepository : IDisabilityInsuranceCompanyRepository
    {
        private readonly DataContext _context;
        public DisabilityInsuranceCompanyRepository(DataContext context)
        {
            _context = context;
        }

        public DisabilityInsuranceCompany GetById(int disabilityInsuranceCompanyId)
        {
            var account = _context.DisabilityInsuranceCompanies.FirstOrDefault(x => x.ID == disabilityInsuranceCompanyId);

            return account;

        }

        public void Insert(DisabilityInsuranceCompany disabilityInsuranceCompany)
        {
            _context.DisabilityInsuranceCompanies.Add(disabilityInsuranceCompany);

            _context.SaveChanges();
        }



        public IEnumerable<DisabilityInsuranceCompany> List()
        {
            return _context.DisabilityInsuranceCompanies.ToList();
        }


        public void SoftDelete(int disabilityInsuranceCompanyId)
        {
            var accountToDelete = _context.DisabilityInsuranceCompanies.Find(disabilityInsuranceCompanyId);

            _context.SaveChanges();

        }

        public void Update(DisabilityInsuranceCompany disabilityInsuranceCompany)
        {
            var trxDisabilityInsuranceCompany = GetById(disabilityInsuranceCompany.ID);
            _context.Entry(trxDisabilityInsuranceCompany).CurrentValues.SetValues(disabilityInsuranceCompany);
            _context.SaveChanges();

        }
    }
}
