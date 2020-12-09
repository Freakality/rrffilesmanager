using RRFFilesManager.Abstractions;
using RRFFilesManager.DataAccess.Abstractions;
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Text;


namespace RRFFilesManager.DataAccess
{
    public class HearAboutUsRepository : IHearAboutUsRepository
    {
        private readonly DataContext _context;
        public HearAboutUsRepository(DataContext context)
        {
            _context = context;
        }

        public  HearAboutUs GetById(int hearAboutUsId)
        {
            var account = _context.HearAboutUs.FirstOrDefault(x => x.ID == hearAboutUsId);

            return account;

        }

        public void Insert(HearAboutUs hearAboutUs)
        {
            _context.HearAboutUs.Add(hearAboutUs);

            _context.SaveChanges();
        }



        public  IEnumerable<HearAboutUs> List()
        {
            return _context.HearAboutUs.ToList(); ;
        }


        public void SoftDelete(int hearAboutUsId)
        {
            var accountToDelete = _context.HearAboutUs.Find(hearAboutUsId);

            _context.SaveChanges();

        }

        public void Update(HearAboutUs hearAboutUs)
        {
            var trxHearAboutUs = GetById(hearAboutUs.ID);
            _context.Entry(trxHearAboutUs).CurrentValues.SetValues(hearAboutUs);
            _context.SaveChanges();

        }
    }
}
