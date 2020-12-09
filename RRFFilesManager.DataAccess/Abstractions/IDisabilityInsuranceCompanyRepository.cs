using RRFFilesManager.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RRFFilesManager.DataAccess.Abstractions
{
    public interface IDisabilityInsuranceCompanyRepository
    {
        void Insert(DisabilityInsuranceCompany disabilityInsuranceCompany);
        void Update(DisabilityInsuranceCompany disabilityInsuranceCompany);
        void SoftDelete(int disabilityInsuranceCompanyId);
        DisabilityInsuranceCompany GetById(int disabilityInsuranceCompanyId);
        IEnumerable<DisabilityInsuranceCompany> List();
    }
}
