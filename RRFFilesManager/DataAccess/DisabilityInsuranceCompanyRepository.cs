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
    public class DisabilityInsuranceCompanyRepository : IDisabilityInsuranceCompanyRepository
    {
        private readonly DataContext _context;
        public DisabilityInsuranceCompanyRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<DisabilityInsuranceCompany> GetByIdAsync(int disabilityInsuranceCompanyId)
        {
            var account = await _context.DisabilityInsuranceCompanies.FirstOrDefaultAsync(x => x.ID == disabilityInsuranceCompanyId).ConfigureAwait(false);

            return account;

        }

        public async Task InsertAsync(DisabilityInsuranceCompany disabilityInsuranceCompany)
        {
            _context.DisabilityInsuranceCompanies.Add(disabilityInsuranceCompany);

            await _context.SaveChangesAsync();
        }



        public async Task<IEnumerable<DisabilityInsuranceCompany>> ListAsync()
        {
            return await _context.DisabilityInsuranceCompanies.ToListAsync().ConfigureAwait(false);
        }


        public async Task SoftDelteAsync(int disabilityInsuranceCompanyId)
        {
            var accountToDelete = await _context.DisabilityInsuranceCompanies.FindAsync(disabilityInsuranceCompanyId);

            await _context.SaveChangesAsync();

        }

        public async Task UpdateAsync(DisabilityInsuranceCompany disabilityInsuranceCompany)
        {
            var trxDisabilityInsuranceCompany = await GetByIdAsync(disabilityInsuranceCompany.ID);
            _context.Entry(trxDisabilityInsuranceCompany).CurrentValues.SetValues(disabilityInsuranceCompany);
            await _context.SaveChangesAsync();

        }
    }
}
