using RRFFilesManager.Abstractions;
using RRFFilesManager.DataAccess.Abstractions;
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Text;


namespace RRFFilesManager.DataAccess
{
    public class OutOfPocketHealthCareExpRepository : IOutOfPocketHealthCareExpRepository
    {
        private readonly DataContext _context;
        public OutOfPocketHealthCareExpRepository(DataContext context)
        {
            _context = context;
        }

        public  OutOfPocketHealthCareExp GetById(int outOfPocketHealthCareExpId)
        {
            var account = _context.OutOfPocketHealthCareExp.FirstOrDefault(x => x.ID == outOfPocketHealthCareExpId);

            return account;

        }

        public void Insert(OutOfPocketHealthCareExp outOfPocketHealthCareExp)
        {
            _context.OutOfPocketHealthCareExp.Add(outOfPocketHealthCareExp);

            _context.SaveChanges();
        }



        public  IEnumerable<OutOfPocketHealthCareExp>List()
        {
            return _context.OutOfPocketHealthCareExp.ToList();
        }

        public IEnumerable<OutOfPocketHealthCareExp> Search(string searchText, int? take = null)
        {
            var query = _context.OutOfPocketHealthCareExp.Where(s =>
                s.File.FileNumber.ToString().Contains(searchText) ||
                s.File.Client.FirstName.Contains(searchText) ||
                s.Pharmacy.Name.Contains(searchText) ||
                s.Drug.Name.Contains(searchText)
            );

            if (take != null)
                query = query.Take(take.Value);

            return query.ToList();
        }
        public void SoftDelete(int outOfPocketHealthCareExpId)
        {
            var accountToDelete = _context.OutOfPocketHealthCareExp.Find(outOfPocketHealthCareExpId);

            _context.SaveChanges();

        }

        public void Update(OutOfPocketHealthCareExp outOfPocketHealthCareExp)
        {
            var trxOutOfPocketHealthCareExp = GetById(outOfPocketHealthCareExp.ID);
            _context.Entry(trxOutOfPocketHealthCareExp).CurrentValues.SetValues(outOfPocketHealthCareExp);
            _context.SaveChanges();

        }
    }
}
