using RRFFilesManager.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RRFFilesManager.DataAccess.Abstractions
{
    public interface IDenialStatusRepository
    {
        void Insert(DenialStatus denialStatus);
        void Update(DenialStatus denialStatus);
        void SoftDelete(int denialStatusId);
        DenialStatus GetById(int denialStatusId);
        IEnumerable<DenialStatus> List();
        DenialStatus GetByDescription(string description);
    }
}
