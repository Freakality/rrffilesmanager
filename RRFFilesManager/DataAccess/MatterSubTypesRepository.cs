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
    public class MatterSubTypeRepository : IMatterSubTypeRepository
    {
        private readonly DataContext _context;
        public MatterSubTypeRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<MatterSubType> GetByIdAsync(int matterSubTypeId)
        {
            var account = await _context.MatterSubTypes.FirstOrDefaultAsync(x => x.ID == matterSubTypeId);

            return account;

        }

        public async Task InsertAsync(MatterSubType matterSubType)
        {
            _context.MatterSubTypes.Add(matterSubType);

            await _context.SaveChangesAsync();
        }



        public async Task<IEnumerable<MatterSubType>> ListAsync()
        {
            return await _context.MatterSubTypes.ToListAsync();
        }


        public async Task SoftDelteAsync(int matterSubTypeId)
        {
            var accountToDelete = await _context.MatterSubTypes.FindAsync(matterSubTypeId);

            await _context.SaveChangesAsync();

        }

        public async Task UpdateAsync(MatterSubType matterSubType)
        {
            var trxMatterSubType = await GetByIdAsync(matterSubType.ID);
            _context.Entry(trxMatterSubType).CurrentValues.SetValues(matterSubType);
            await _context.SaveChangesAsync();

        }
    }
}
