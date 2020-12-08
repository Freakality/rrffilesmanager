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
    public class LawyerRepository : ILawyerRepository
    {
        private readonly DataContext _context;
        public LawyerRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<Lawyer> GetByIdAsync(int lawyerId)
        {
            var account = await _context.Lawyers.FirstOrDefaultAsync(x => x.ID == lawyerId).ConfigureAwait(false);

            return account;

        }

        public async Task InsertAsync(Lawyer lawyer)
        {
            _context.Lawyers.Add(lawyer);

            await _context.SaveChangesAsync();
        }



        public async Task<IEnumerable<Lawyer>> ListAsync()
        {
            return await _context.Lawyers.ToListAsync().ConfigureAwait(false); ;
        }


        public async Task SoftDelteAsync(int lawyerId)
        {
            var accountToDelete = await _context.Lawyers.FindAsync(lawyerId);

            await _context.SaveChangesAsync();

        }

        public async Task UpdateAsync(Lawyer lawyer)
        {
            var trxLawyer = await GetByIdAsync(lawyer.ID);
            _context.Entry(trxLawyer).CurrentValues.SetValues(lawyer);
            await _context.SaveChangesAsync();

        }
    }
}
