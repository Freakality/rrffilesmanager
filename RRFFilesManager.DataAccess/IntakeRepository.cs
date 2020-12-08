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
    public class IntakeRepository : IIntakeRepository
    {
        private readonly DataContext _context;
        public IntakeRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<Intake> GetByIdAsync(int intakeId)
        {
            var account = await _context.Intakes.FirstOrDefaultAsync(x => x.ID == intakeId).ConfigureAwait(false);
            return account;
        }

        public async Task InsertAsync(Intake intake, File file)
        {
            intake.File = file;
            _context.Intakes.Add(intake);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Intake>> ListAsync()
        {
            return await _context.Intakes.ToListAsync().ConfigureAwait(false); ;
        }

        public async Task SoftDelteAsync(int intakeId)
        {
            var accountToDelete = await GetByIdAsync(intakeId);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Intake intake)
        {
            var trxIntake = await GetByIdAsync(intake.ID);
            _context.Entry(trxIntake).CurrentValues.SetValues(intake);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Intake>> SearchAsync(string searchText, bool? hold = null, int? take = null)
        {
            var query = _context.Intakes.Where(s =>
                s.File.FileNumber.ToString().Contains(searchText) ||
                s.File.Client.FirstName.Contains(searchText) ||
                s.File.Client.LastName.Contains(searchText) ||
                s.File.Client.Email.Contains(searchText) ||
                s.File.MatterType.Description.Contains(searchText)
            );
            if (hold != null)
                query = query.Where(s => s.Hold == hold);

            if (take != null)
                query = query.Take(take.Value);

            return await query.ToListAsync().ConfigureAwait(false);
        }
    }
}
