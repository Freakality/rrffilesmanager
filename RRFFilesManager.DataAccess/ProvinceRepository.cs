using RRFFilesManager.Abstractions;
using RRFFilesManager.DataAccess.Abstractions;
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Text;


namespace RRFFilesManager.DataAccess
{
    public class ProvinceRepository : IProvinceRepository
    {
        private readonly DataContext _context;
        public ProvinceRepository(DataContext context)
        {
            _context = context;
        }

        public Province GetById(int provinceId)
        {
            var account = _context.Provinces.FirstOrDefault(x => x.ID == provinceId);

            return account;

        }

        public void Insert(Province province)
        {
            _context.Provinces.Add(province);

            _context.SaveChanges();
        }



        public IEnumerable<Province> List()
        {
            return _context.Provinces.ToList(); ;
        }


        public void SoftDelete(int provinceId)
        {
            var accountToDelete = _context.Provinces.Find(provinceId);

            _context.SaveChanges();

        }

        public void Update(Province province)
        {
            var trxProvince = GetById(province.ID);
            _context.Entry(trxProvince).CurrentValues.SetValues(province);
            _context.SaveChanges();

        }
    }
}
