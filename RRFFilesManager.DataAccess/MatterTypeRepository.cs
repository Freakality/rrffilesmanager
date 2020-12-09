using RRFFilesManager.Abstractions;
using RRFFilesManager.DataAccess.Abstractions;
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Text;


namespace RRFFilesManager.DataAccess
{
    public class MatterTypeRepository : IMatterTypeRepository
    {
        private readonly DataContext _context;
        public MatterTypeRepository(DataContext context)
        {
            _context = context;
        }

        public MatterType GetById(int matterTypeId)
        {
            var matterType = _context.MatterTypes.FirstOrDefault(x => x.ID == matterTypeId);

            return matterType;

        }

        public void Insert(MatterType matterType)
        {
            _context.MatterTypes.Add(matterType);

            _context.SaveChanges();
        }



        public IEnumerable<MatterType> List()
        {
            var matterTypes = _context.MatterTypes.ToList();
            return matterTypes;
        }


        public void SoftDelete(int matterTypeId)
        {
            var accountToDelete = _context.MatterTypes.Find(matterTypeId);

            _context.SaveChanges();

        }

        public void Update(MatterType matterType)
        {
            var trxMatterType = GetById(matterType.ID);
            _context.Entry(trxMatterType).CurrentValues.SetValues(matterType);
            _context.SaveChanges();

        }
    }
}
