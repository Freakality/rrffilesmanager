using RRFFilesManager.Abstractions;
using RRFFilesManager.DataAccess.Abstractions;
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Text;

namespace RRFFilesManager.DataAccess
{
    public class LATDataRepository : ILATDataRepository
    {
        private readonly DataContext _context;
        public LATDataRepository(DataContext context)
        {
            _context = context;
        }

        public LATData GetById(int latDataId)
        {
            var account = _context.LATDatas.FirstOrDefault(x => x.ID == latDataId);
            return account;
        }

        public void Insert(LATData latData, int latNumber, File file)
        {
            latData.File = file;
            latData.LATNumber = latNumber;
            _context.LATDatas.Add(latData);
            _context.SaveChanges();
        }

        public IEnumerable<LATData> List()
        {
            return _context.LATDatas.ToList(); ;
        }

        public void SoftDelete(int latDataId)
        {
            var accountToDelete = GetById(latDataId);
            _context.SaveChanges();
        }

        public void Update(LATData latData)
        {
            var trxFile = GetById(latData.ID);
            _context.Entry(trxFile).CurrentValues.SetValues(latData) ;
            _context.SaveChanges();
        }

        public IEnumerable<LATData> Search(File file, int latNumber, int? take = null)
        {
            var query = _context.LATDatas.Where(s =>
                s.File.ID == file.ID &&
                s.LATNumber == latNumber 
            );

            if (take != null)
                query = query.Take(take.Value);

            return query.ToList();
        }
    }
}
