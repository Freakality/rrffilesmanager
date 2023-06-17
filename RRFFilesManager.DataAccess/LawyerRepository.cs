﻿using RRFFilesManager.Abstractions;
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
            var account = _context.Lawyers.FirstOrDefault(x => x.Description.Contains(searchText));

            return account;
        }

        public Lawyer GetByDescription(string searchText)
        {
            var account = _context.Lawyers.FirstOrDefault(x => x.Description == (searchText));

            return account;
        }


        public  IEnumerable<Lawyer>List(bool? isParalegal = null)
        {
            if(isParalegal != null)
                return _context.Lawyers.Where(s => s.IsParalegal == isParalegal && s.Description != "DEVTEST_USER" && s.Active == true).ToList();
            return _context.Lawyers.Where(s => s.Description != "DEVTEST_USER" && s.Active == true).ToList();
        }


        public void SoftDelete(int lawyerId)
        {
            var trxLawyer = GetById(lawyerId);
            trxLawyer.Active = false;
            //_context.Entry(trxLawyer).Active = EntityState.Deleted;
            _context.SaveChanges();
        }

        public void Update(Lawyer lawyer)
        {
            var trxLawyer = GetById(lawyer.ID);
            _context.Entry(trxLawyer).CurrentValues.SetValues(lawyer);
            _context.SaveChanges();

        }

        public void Delete(Lawyer lawyer)
        {
            var trxLawyer = GetById(lawyer.ID);
            _context.Remove(trxLawyer);
            _context.SaveChanges();
        }
    }
}
