using RRFFilesManager.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RRFFilesManager.DataAccess.Abstractions
{
    public interface IStandardBenefitRowRepository
    {
        void Insert(Archive archive, StandardBenefitRow standardBenefitRow);
        void Update(StandardBenefitRow standardBenefitRow);
        void SoftDelete(int rowId);
        void Delete(StandardBenefitRow standardBenefitRow);
        StandardBenefitRow GetById(int rowId);
        IEnumerable<StandardBenefitRow> List(int? archiveID = null);
    }
}
