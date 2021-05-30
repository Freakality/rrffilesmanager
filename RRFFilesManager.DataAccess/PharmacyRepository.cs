using RRFFilesManager.Abstractions;
using RRFFilesManager.DataAccess.Abstractions;
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Text;


namespace RRFFilesManager.DataAccess
{
    public class PharmacyRepository : IPharmacyRepository
    {
        private readonly DataContext _context;
        public PharmacyRepository(DataContext context)
        {
            _context = context;
        }

        public  Pharmacy GetById(int pharmacyId)
        {
            var account = _context.Pharmacies.FirstOrDefault(x => x.ID == pharmacyId);

            return account;

        }

        public void Insert(Pharmacy pharmacy)
        {
            _context.Pharmacies.Add(pharmacy);

            _context.SaveChanges();
        }



        public  IEnumerable<Pharmacy>List()
        {
            return _context.Pharmacies.ToList();
        }

        public IEnumerable<Pharmacy> Search(string searchText, int? take = null)
        {
            var query = _context.Pharmacies.Where(s =>
                s.Name.Contains(searchText)
            );

            if (take != null)
                query = query.Take(take.Value);

            return query.ToList();
        }
        public void SoftDelete(int pharmacyId)
        {
            var accountToDelete = _context.Pharmacies.Find(pharmacyId);

            _context.SaveChanges();

        }

        public void Update(Pharmacy pharmacy)
        {
            var trxPharmacy = GetById(pharmacy.ID);
            _context.Entry(trxPharmacy).CurrentValues.SetValues(pharmacy);
            _context.SaveChanges();

        }
    }
}
