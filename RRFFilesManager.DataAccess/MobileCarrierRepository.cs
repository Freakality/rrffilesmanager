using RRFFilesManager.Abstractions;
using RRFFilesManager.DataAccess.Abstractions;
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Text;


namespace RRFFilesManager.DataAccess
{
    public class MobileCarrierRepository : IMobileCarrierRepository
    {
        private readonly DataContext _context;
        public MobileCarrierRepository(DataContext context)
        {
            _context = context;
        }

        public MobileCarrier GetById(int mobileCarrierId)
        {
            var account = _context.MobileCarriers.FirstOrDefault(x => x.ID == mobileCarrierId);

            return account;

        }

        public void Insert(MobileCarrier mobileCarrier)
        {
            _context.MobileCarriers.Add(mobileCarrier);

            _context.SaveChanges();
        }



        public IEnumerable<MobileCarrier> List()
        {
            return _context.MobileCarriers.ToList(); ;
        }


        public void SoftDelete(int mobileCarrierId)
        {
            var accountToDelete = _context.MobileCarriers.Find(mobileCarrierId);

            _context.SaveChanges();

        }

        public void Update(MobileCarrier mobileCarrier)
        {
            var trxMobileCarrier = GetById(mobileCarrier.ID);
            _context.Entry(trxMobileCarrier).CurrentValues.SetValues(mobileCarrier);
            _context.SaveChanges();

        }
    }
}
