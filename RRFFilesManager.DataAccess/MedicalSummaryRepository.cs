using RRFFilesManager.Abstractions;
using RRFFilesManager.DataAccess.Abstractions;
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Text;


namespace RRFFilesManager.DataAccess
{
    public class MedicalSummaryRepository : IMedicalSummaryRepository
    {
        private readonly DataContext _context;
        public MedicalSummaryRepository(DataContext context)
        {
            _context = context;
        }

        public  MedicalSummary GetById(int medicalSummaryId)
        {
            var account = _context.MedicalSummaries.FirstOrDefault(x => x.ID == medicalSummaryId);

            return account;

        }

        public void Insert(MedicalSummary medicalSummary)
        {
            _context.MedicalSummaries.Add(medicalSummary);

            _context.SaveChanges();
        }



        public  IEnumerable<MedicalSummary>List()
        {
            return _context.MedicalSummaries.ToList();
        }

        public IEnumerable<MedicalSummary> Search(string searchText, int? take = null)
        {
            var query = _context.MedicalSummaries.Where(s =>
                s.File.FileNumber.ToString().Contains(searchText) ||
                s.File.Client.FirstName.Contains(searchText)
            );

            if (take != null)
                query = query.Take(take.Value);

            return query.ToList();
        }
        public void Delete(MedicalSummary medicalSummary)
        {
            var trxMedicalSummary = GetById(medicalSummary.ID);
            _context.MedicalSummaries.Remove(trxMedicalSummary);
            _context.SaveChanges();
        }

        public void Update(MedicalSummary medicalSummary)
        {
            var trxMedicalSummary = GetById(medicalSummary.ID);
            _context.Entry(trxMedicalSummary).CurrentValues.SetValues(medicalSummary);
            _context.SaveChanges();

        }
    }
}
