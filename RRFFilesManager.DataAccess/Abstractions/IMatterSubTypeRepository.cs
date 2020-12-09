using RRFFilesManager.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace RRFFilesManager.DataAccess.Abstractions
{
    public interface IMatterSubTypeRepository
    {
        void Insert(MatterSubType matterSubType);
        void Update(MatterSubType matterSubType);
        void SoftDelete(int matterSubTypeId);
        MatterSubType GetById(int matterSubTypeId);
        IEnumerable<MatterSubType> List();
    }
}
