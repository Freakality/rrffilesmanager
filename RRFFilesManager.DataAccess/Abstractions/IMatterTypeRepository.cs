using RRFFilesManager.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace RRFFilesManager.DataAccess.Abstractions
{
    public interface IMatterTypeRepository
    {
        void Insert(MatterType matterType);
        void Update(MatterType matterType);
        void SoftDelete(int matterTypeId);
        MatterType GetById(int matterTypeId);
        IEnumerable<MatterType> List();
    }
}
