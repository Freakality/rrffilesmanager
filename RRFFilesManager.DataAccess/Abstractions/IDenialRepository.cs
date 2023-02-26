using RRFFilesManager.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RRFFilesManager.DataAccess.Abstractions
{
    public interface IDenialRepository
    {
        void Insert(Denial denial, File file);
        void Update(Denial denial);
        void SoftDelete(int denialId);
        Denial GetById(int denialId);
        IEnumerable<Denial> List();
        IEnumerable<Denial> Search(File file, DenialBenefit denialBenefit = null, DenialStatus denialStatus = null, int? take = null);
    }
}
