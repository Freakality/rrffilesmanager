using Microsoft.EntityFrameworkCore;
using RRFFilesManager.Abstractions;
using RRFFilesManager.DataAccess.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace RRFFilesManager.DataAccess
{
    public class CompanyRepository : ICompanyRepository
    {
        private readonly DataContext _context;
        public CompanyRepository(DataContext context)
        {
            _context = context;
        }

        public  Company GetById(int companyId)
        {
            var account = _context.Companies.FirstOrDefault(x => x.ID == companyId);

            return account;

        }

        public void Insert(Company company)
        {
            _context.Companies.Add(company);

            _context.SaveChanges();
        }



        public  IEnumerable<Company> List()
        {
            return _context.Companies.ToList();
        }


        public void SoftDelete(int companyId)
        {
            var accountToDelete = GetById(companyId);

            _context.SaveChanges();

        }

        public void Update(Company company)
        {
            var trxCompany = GetById(company.ID);
            _context.Entry(trxCompany).CurrentValues.SetValues(company);
            _context.SaveChanges();

        }

        public IEnumerable<Company> Search(string searchText, int? take = null)
        {
            var query = _context.Companies.Where(s =>
                s.Description.Contains(searchText) ||
                s.Email.Contains(searchText) ||
                s.ID.ToString().Contains(searchText)
            );
            if (take != null)
            {
                query = query.Take(take.Value);
            }
            return query.ToList();
        }
    }
}
