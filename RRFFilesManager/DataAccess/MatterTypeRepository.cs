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
    public class MatterTypeRepository : IMatterTypeRepository
    {
        private readonly DataContext _context;
        public MatterTypeRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<MatterType> GetByIdAsync(int matterTypeId)
        {
            var account = await _context.MatterTypes.FirstOrDefaultAsync(x => x.ID == matterTypeId);

            return account;

        }

        public async Task InsertAsync(MatterType matterType)
        {
            _context.MatterTypes.Add(matterType);

            await _context.SaveChangesAsync();
        }



        public async Task<IEnumerable<MatterType>> ListAsync()
        {
            return await _context.MatterTypes.ToListAsync();
        }


        public async Task SoftDelteAsync(int matterTypeId)
        {
            var accountToDelete = await _context.MatterTypes.FindAsync(matterTypeId);

            await _context.SaveChangesAsync();

        }

        public async Task UpdateAsync(MatterType matterType)
        {
            var trxMatterType = this.GetByIdAsync(matterType.ID);
            _context.Entry(trxMatterType).CurrentValues.SetValues(matterType);
            await _context.SaveChangesAsync();

        }
    }
}
