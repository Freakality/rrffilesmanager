using RRFFilesManager.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace RRFFilesManager.DataAccess.Abstractions
{
    public interface IGroupRepository
    {
        void Insert(Group group);
        void Update(Group group);
        void SoftDelete(int groupId);
        Group GetById(int groupId);
        IEnumerable<Group> List();
    }
}
