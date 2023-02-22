using RRFFilesManager.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace RRFFilesManager.DataAccess.Abstractions
{
    public interface IPermissionRepository
    {
        void Insert(Permission permission);
        void Update(Permission permission);
        void SoftDelete(int permissionsId);
        Permission GetById(int permissionId);
        Permission GetByDescription(string description);
        IEnumerable<Permission> List();
    }
}
