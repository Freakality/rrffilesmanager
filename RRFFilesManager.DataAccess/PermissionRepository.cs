using RRFFilesManager.Abstractions;
using RRFFilesManager.DataAccess.Abstractions;
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Text;


namespace RRFFilesManager.DataAccess
{
    public class PermissionRepository : IPermissionRepository
    {
        private readonly DataContext _context;
        public PermissionRepository(DataContext context)
        {
            _context = context;
        }

        public Permission GetById(int taskStateId)
        {
            var account = _context.Permissions.FirstOrDefault(x => x.ID == taskStateId);

            return account;

        }

        public Permission GetByDescription(string description)
        {
            var account = _context.Permissions.FirstOrDefault(x => x.ButtonDescription == description);

            return account;

        }

        public void Insert(Permission permission)
        {
            _context.Permissions.Add(permission);
            _context.SaveChanges();
        }



        public IEnumerable<Permission> List()
        {
            return _context.Permissions.ToList(); ;
        }


        public void SoftDelete(int permissionId)
        {
            var accountToDelete = _context.Permissions.Find(permissionId);
            _context.SaveChanges();

        }

        public void Update(Permission permission)
        {
            var trxPermission = GetById(permission.ID);
            _context.Entry(trxPermission).CurrentValues.SetValues(permission);
            _context.SaveChanges();

        }
    }
}
