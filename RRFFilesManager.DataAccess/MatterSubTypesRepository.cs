using RRFFilesManager.Abstractions;
using RRFFilesManager.DataAccess.Abstractions;
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Text;


namespace RRFFilesManager.DataAccess
{
    public class MatterSubTypeRepository : IMatterSubTypeRepository
    {
        private readonly DataContext _context;
        public MatterSubTypeRepository(DataContext context)
        {
            _context = context;
        }

        public  MatterSubType GetById(int matterSubTypeId)
        {
            var account = _context.MatterSubTypes.FirstOrDefault(x => x.ID == matterSubTypeId);

            return account;

        }

        public void Insert(MatterSubType matterSubType)
        {
            _context.MatterSubTypes.Add(matterSubType);

            _context.SaveChanges();
        }



        public  IEnumerable<MatterSubType> List()
        {
            return _context.MatterSubTypes.ToList(); ;
        }


        public void SoftDelete(int matterSubTypeId)
        {
            var accountToDelete = _context.MatterSubTypes.Find(matterSubTypeId);

            _context.SaveChanges();

        }

        public void Update(MatterSubType matterSubType)
        {
            var trxMatterSubType = GetById(matterSubType.ID);
            _context.Entry(trxMatterSubType).CurrentValues.SetValues(matterSubType);
            _context.SaveChanges();

        }
    }
}
