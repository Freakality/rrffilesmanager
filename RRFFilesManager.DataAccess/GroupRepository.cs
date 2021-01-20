using RRFFilesManager.Abstractions;
using RRFFilesManager.DataAccess.Abstractions;
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Text;


namespace RRFFilesManager.DataAccess
{
    public class GroupRepository : IGroupRepository
    {
        private readonly DataContext _context;
        public GroupRepository(DataContext context)
        {
            _context = context;
        }

        public  Group GetById(int groupId)
        {
            var group = _context.Groups.FirstOrDefault(x => x.ID == groupId);

            return group;

        }

        public void Insert(Group group)
        {
            _context.Groups.Add(group);

            _context.SaveChanges();
        }



        public  IEnumerable<Group> List()
        {
            return _context.Groups.ToList(); ;
        }


        public void SoftDelete(int groupId)
        {
            var accountToDelete = _context.Groups.Find(groupId);

            _context.SaveChanges();

        }

        public void Update(Group group)
        {
            var trxGroup = GetById(group.ID);
            _context.Entry(trxGroup).CurrentValues.SetValues(group);
            _context.SaveChanges();

        }
    }
}
