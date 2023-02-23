using RRFFilesManager.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RRFFilesManager.DataAccess.Abstractions
{
    public interface IDenialBenefitRepository
    {
        void Insert(DenialBenefit denialStatus);
        void Update(DenialBenefit denialStatus);
        void SoftDelete(int denialBenefitId);
        DenialBenefit GetById(int denialBenefitId);
        IEnumerable<DenialBenefit> List();
        DenialBenefit GetByDescription(string description);
    }
}
