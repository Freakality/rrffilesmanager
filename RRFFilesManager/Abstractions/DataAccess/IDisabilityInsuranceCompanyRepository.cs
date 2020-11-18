using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RRFFilesManager.Abstractions.DataAccess
{
    public interface IDisabilityInsuranceCompanyRepository
    {
        Task InsertAsync(DisabilityInsuranceCompany disabilityInsuranceCompany);
        Task UpdateAsync(DisabilityInsuranceCompany disabilityInsuranceCompany);
        Task SoftDelteAsync(int disabilityInsuranceCompanyId);
        Task<DisabilityInsuranceCompany> GetByIdAsync(int disabilityInsuranceCompanyId);
        Task<IEnumerable<DisabilityInsuranceCompany>> ListAsync();
    }
}
