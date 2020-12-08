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
    public class HearAboutUsRepository : IHearAboutUsRepository
    {
        private readonly DataContext _context;
        public HearAboutUsRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<HearAboutUs> GetByIdAsync(int hearAboutUsId)
        {
            var account = await _context.HearAboutUs.FirstOrDefaultAsync(x => x.ID == hearAboutUsId).ConfigureAwait(false);

            return account;

        }

        public async Task InsertAsync(HearAboutUs hearAboutUs)
        {
            _context.HearAboutUs.Add(hearAboutUs);

            await _context.SaveChangesAsync();
        }



        public async Task<IEnumerable<HearAboutUs>> ListAsync()
        {
            return await _context.HearAboutUs.ToListAsync().ConfigureAwait(false); ;
        }


        public async Task SoftDelteAsync(int hearAboutUsId)
        {
            var accountToDelete = await _context.HearAboutUs.FindAsync(hearAboutUsId);

            await _context.SaveChangesAsync();

        }

        public async Task UpdateAsync(HearAboutUs hearAboutUs)
        {
            var trxHearAboutUs = await GetByIdAsync(hearAboutUs.ID);
            _context.Entry(trxHearAboutUs).CurrentValues.SetValues(hearAboutUs);
            await _context.SaveChangesAsync();

        }
    }
}
