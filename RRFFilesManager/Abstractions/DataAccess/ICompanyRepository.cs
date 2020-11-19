using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RRFFilesManager.Abstractions.DataAccess
{
    public interface ICompanyRepository
    {
        Task InsertAsync(Company company);
        Task UpdateAsync(Company company);
        Task SoftDelteAsync(int companyId);
        Task<Company> GetByIdAsync(int companyId);
        Task<IEnumerable<Company>> ListAsync();
    }
}
