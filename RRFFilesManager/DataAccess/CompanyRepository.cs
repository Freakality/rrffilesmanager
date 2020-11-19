using RRFFilesManager.Abstractions;
using RRFFilesManager.Abstractions.DataAccess;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RRFFilesManager.DataAccess
{
    public class CompanyRepository : ICompanyRepository
    {
        private readonly DataContext _context;
        public CompanyRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<Company> GetByIdAsync(int companyId)
        {
            var account = await _context.Companies.FirstOrDefaultAsync(x => x.ID == companyId);

            return account;

        }

        public async Task InsertAsync(Company company)
        {
            _context.Companies.Add(company);

            await _context.SaveChangesAsync();
        }



        public async Task<IEnumerable<Company>> ListAsync()
        {
            return await _context.Companies.ToListAsync();
        }


        public async Task SoftDelteAsync(int companyId)
        {
            var accountToDelete = await _context.Companies.FindAsync(companyId);

            await _context.SaveChangesAsync();

        }

        public async Task UpdateAsync(Company company)
        {
            var trxCompany = await GetByIdAsync(company.ID);
            _context.Entry(trxCompany).CurrentValues.SetValues(company);
            await _context.SaveChangesAsync();

        }
    }
}
