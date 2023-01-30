using RRFFilesManager.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RRFFilesManager.DataAccess.Abstractions
{
    public interface ILATDataRepository
    {
        void Insert(LATData latData, int latNumber, File file);
        void Update(LATData latData);
        void SoftDelete(int latDataId);
        LATData GetById(int latDataId);
        IEnumerable<LATData> List();
        IEnumerable<LATData> Search(File file, int LATNumber, int? take = null);
    }
}
