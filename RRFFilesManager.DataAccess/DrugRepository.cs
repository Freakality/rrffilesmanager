using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Text;
using RRFFilesManager.Abstractions;
using RRFFilesManager.DataAccess;
using RRFFilesManager.DataAccess.Abstractions;

namespace RRFFilesManager.DataAccess
{
    public class DrugRepository : IDrugRepository
    {
        private readonly DataContext _context;
        public DrugRepository(DataContext context)
        {
            _context = context;
        }

        public  Drug GetById(int drugId)
        {
            var account = _context.Drugs.FirstOrDefault(x => x.ID == drugId);
            return account;
        }

        public void Insert(Drug drug)
        {
            _context.Drugs.Add(drug);
            _context.SaveChanges();
        }

        public  IEnumerable<Drug> List()
        {
            var query = _context.Drugs.AsQueryable();
            return query.ToList();
        }

        public IEnumerable<Drug> Search(string searchText, int? take = null)
        {
            var query = _context.Drugs.Where(s =>
                s.DIN.Contains(searchText) ||
                s.Name.Contains(searchText)
            );

            if (take != null)
                query = query.Take(take.Value);

            return query.ToList();
        }

        public void SoftDelete(int drugId)
        {
            var accountToDelete = GetById(drugId);
            _context.SaveChanges();
        }

        public void Delete(Drug drug)
        {
            var trxDrug = GetById(drug.ID);
            _context.Drugs.Remove(trxDrug);
            _context.SaveChanges();
        }

        public void Update(Drug drug)
        {
            var trxDrug = GetById(drug.ID);
            _context.Entry(trxDrug).CurrentValues.SetValues(drug);
            _context.SaveChanges();
        }
        
    }
}
