using RRFFilesManager.Abstractions;
using RRFFilesManager.DataAccess.Abstractions;
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
            var account = await _context.Companies.FirstOrDefaultAsync(x => x.ID == companyId).ConfigureAwait(false);

            return account;

        }

        public async Task InsertAsync(Company company)
        {
            _context.Companies.Add(company);

            await _context.SaveChangesAsync().ConfigureAwait(false);
        }



        public async Task<IEnumerable<Company>> ListAsync()
        {
            return await _context.Companies.ToListAsync().ConfigureAwait(false);
        }


        public async Task SoftDelteAsync(int companyId)
        {
            var accountToDelete = await GetByIdAsync(companyId);

            await _context.SaveChangesAsync().ConfigureAwait(false);

        }

        public async Task UpdateAsync(Company company)
        {
            var trxCompany = await GetByIdAsync(company.ID);
            _context.Entry(trxCompany).CurrentValues.SetValues(company);
            await _context.SaveChangesAsync().ConfigureAwait(false);

        }
    }
}
