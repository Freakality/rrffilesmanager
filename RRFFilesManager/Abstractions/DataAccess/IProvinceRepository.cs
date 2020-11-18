using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RRFFilesManager.Abstractions.DataAccess
{
    public interface IProvinceRepository
    {
        Task InsertAsync(Province province);
        Task UpdateAsync(Province province);
        Task SoftDelteAsync(int provinceId);
        Task<Province> GetByIdAsync(int provinceId);
        Task<IEnumerable<Province>> ListAsync();
    }
}
