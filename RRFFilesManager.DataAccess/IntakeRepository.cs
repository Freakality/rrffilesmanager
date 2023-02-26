using RRFFilesManager.Abstractions;
using RRFFilesManager.DataAccess.Abstractions;
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Data;

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

        public IEnumerable<object> SearchInfoForReporting(DateTime from, DateTime to)
        {
            //var query = from y in _context.Intakes
            //            select new
            //            {
            //                DateOfCall = y.File.DateOfCall.ToString(),
            //                Interviewer = y.File.StaffInterviewer.Description,
            //                TypeOfMatter = y.File.MatterType.Description,
            //                HowHear = y.File.HowHear.Description,
            //                DateOfLoss = y.File.DateOFLoss.ToString(),
            //                ResponsibleLawyer = y.File.ResponsibleLawyer.Description,
            //                FileLaweyer = y.File.FileLawyer.Description,
            //                Status = y.File.CurrentStatus.Description,
            //                LastName = y.File.Client.LastName,
            //                FirstName = y.File.Client.FirstName
            //            };

            //var personData = _context.Database<Intake>();

            //Console.WriteLine(personData.TableName); // output: People
            //var nameColumn = personData.Prop("Name");
            //Console.WriteLine(nameColumn.ColumnName); // output: MyName


            var query = _context.Intakes.Where(j => j.File.DateOfCall >= from && j.File.DateOfCall <= to).Select(x => new
            {
                DateOfCall = x.File.DateOfCall.ToString("dd/MM/yyyy"),
                Interviewer = x.File.StaffInterviewer.Description,
                TypeOfMatter = x.File.MatterType.Description,
                HowHearAboutUs = x.File.HowHear.Description,
                DateOfLoss = x.File.DateOFLoss.ToString("dd/MM/yyyy"),
                ResponsibleLawyer = x.File.ResponsibleLawyer.Description,
                FileLawyer = x.File.FileLawyer.Description,
                Status = x.File.CurrentStatus.Description,
                LastName = x.File.Client.LastName,
                FirstName = x.File.Client.FirstName
            });
            return query.ToList();
        }
    }
}
