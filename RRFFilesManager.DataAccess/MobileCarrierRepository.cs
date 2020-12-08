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
    public class MobileCarrierRepository : IMobileCarrierRepository
    {
        private readonly DataContext _context;
        public MobileCarrierRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<MobileCarrier> GetByIdAsync(int mobileCarrierId)
        {
            var account = await _context.MobileCarriers.FirstOrDefaultAsync(x => x.ID == mobileCarrierId).ConfigureAwait(false);

            return account;

        }

        public async Task InsertAsync(MobileCarrier mobileCarrier)
        {
            _context.MobileCarriers.Add(mobileCarrier);

            await _context.SaveChangesAsync();
        }



        public async Task<IEnumerable<MobileCarrier>> ListAsync()
        {
            return await _context.MobileCarriers.ToListAsync().ConfigureAwait(false); ;
        }


        public async Task SoftDelteAsync(int mobileCarrierId)
        {
            var accountToDelete = await _context.MobileCarriers.FindAsync(mobileCarrierId);

            await _context.SaveChangesAsync();

        }

        public async Task UpdateAsync(MobileCarrier mobileCarrier)
        {
            var trxMobileCarrier = await GetByIdAsync(mobileCarrier.ID);
            _context.Entry(trxMobileCarrier).CurrentValues.SetValues(mobileCarrier);
            await _context.SaveChangesAsync();

        }
    }
}
