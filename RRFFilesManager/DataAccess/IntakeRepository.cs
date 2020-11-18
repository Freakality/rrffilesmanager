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
    public class IntakeRepository : IIntakeRepository
    {
        private readonly DataContext _context;
        public IntakeRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<Intake> GetByIdAsync(int intakeId)
        {
            var account = await _context.Intakes.FirstOrDefaultAsync(x => x.ID == intakeId);
            return account;
        }

        public async Task InsertAsync(Intake intake)
        {
            _context.Intakes.Add(intake);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Intake>> ListAsync()
        {
            return await _context.Intakes.ToListAsync();
        }

        public async Task SoftDelteAsync(int intakeId)
        {
            var accountToDelete = await _context.Intakes.FindAsync(intakeId);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Intake intake)
        {
            var trxMatterType = this.GetByIdAsync(intake.ID);
            _context.Entry(trxMatterType).CurrentValues.SetValues(intake);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Intake>> SearchAsync(string searchText)
        {
            return _context.Intakes.Where(s => s.Hold).Where(s =>
                s.FileNumber.ToString().Contains(searchText) ||
                s.Client.FirstName.Contains(searchText) ||
                s.Client.LastName.Contains(searchText) ||
                s.Client.Email.Contains(searchText) ||
                s.MatterType.Description.Contains(searchText)
            );
        }
    }
}
