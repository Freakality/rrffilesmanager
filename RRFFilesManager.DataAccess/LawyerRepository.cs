using RRFFilesManager.Abstractions;
using RRFFilesManager.DataAccess.Abstractions;
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Text;


namespace RRFFilesManager.DataAccess
{
    public class LawyerRepository : ILawyerRepository
    {
        private readonly DataContext _context;
        public LawyerRepository(DataContext context)
        {
            _context = context;
        }

        public  Lawyer GetById(int lawyerId)
        {
            var account = _context.Lawyers.FirstOrDefault(x => x.ID == lawyerId);

            return account;

        }
        public Lawyer GetByUserName(string userName)
        {
            var account = _context.Lawyers.FirstOrDefault(x => x.UserName == userName);

            return account;

        }

        public void Insert(Lawyer lawyer)
        {
            _context.Lawyers.Add(lawyer);

            _context.SaveChanges();
        }

        public Lawyer GetByName(string searchText)
        {
            var account = _context.Lawyers.FirstOrDefault(x => x.Description.ToString().Contains(searchText));

            return account;
        }


        public  IEnumerable<Lawyer>List(bool? isParalegal = null)
        {
            if(isParalegal != null)
                return _context.Lawyers.Where(s => s.IsParalegal == isParalegal).ToList();
            return _context.Lawyers.ToList();
        }


        public void SoftDelete(int lawyerId)
        {
            var accountToDelete = _context.Lawyers.Find(lawyerId);

            _context.SaveChanges();

        }

        public void Update(Lawyer lawyer)
        {
            var trxLawyer = GetById(lawyer.ID);
            _context.Entry(trxLawyer).CurrentValues.SetValues(lawyer);
            _context.SaveChanges();

        }
    }
}
