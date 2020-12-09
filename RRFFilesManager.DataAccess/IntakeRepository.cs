using RRFFilesManager.Abstractions;
using RRFFilesManager.DataAccess.Abstractions;
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Text;


namespace RRFFilesManager.DataAccess
{
    public class IntakeRepository : IIntakeRepository
    {
        private readonly DataContext _context;
        public IntakeRepository(DataContext context)
        {
            _context = context;
        }

        public  Intake GetById(int intakeId)
        {
            var account = _context.Intakes.FirstOrDefault(x => x.ID == intakeId);
            return account;
        }

        public void Insert(Intake intake, File file)
        {
            intake.File = file;
            _context.Intakes.Add(intake);
            _context.SaveChanges();
        }

        public  IEnumerable<Intake> List()
        {
            return _context.Intakes.ToList(); ;
        }

        public void SoftDelete(int intakeId)
        {
            var accountToDelete = GetById(intakeId);
            _context.SaveChanges();
        }

        public void Update(Intake intake)
        {
            var trxIntake = GetById(intake.ID);
            _context.Entry(trxIntake).CurrentValues.SetValues(intake);
            _context.SaveChanges();
        }

        public  IEnumerable<Intake> Search(string searchText, bool? hold = null, int? take = null)
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
            return query.ToList();
        }
    }
}
