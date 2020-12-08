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
    public class ProvinceRepository : IProvinceRepository
    {
        private readonly DataContext _context;
        public ProvinceRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<Province> GetByIdAsync(int provinceId)
        {
            var account = await _context.Provinces.FirstOrDefaultAsync(x => x.ID == provinceId).ConfigureAwait(false);

            return account;

        }

        public async Task InsertAsync(Province province)
        {
            _context.Provinces.Add(province);

            await _context.SaveChangesAsync();
        }



        public async Task<IEnumerable<Province>> ListAsync()
        {
            return await _context.Provinces.ToListAsync().ConfigureAwait(false); ;
        }


        public async Task SoftDelteAsync(int provinceId)
        {
            var accountToDelete = await _context.Provinces.FindAsync(provinceId);

            await _context.SaveChangesAsync();

        }

        public async Task UpdateAsync(Province province)
        {
            var trxProvince = await GetByIdAsync(province.ID);
            _context.Entry(trxProvince).CurrentValues.SetValues(province);
            await _context.SaveChangesAsync();

        }
    }
}
