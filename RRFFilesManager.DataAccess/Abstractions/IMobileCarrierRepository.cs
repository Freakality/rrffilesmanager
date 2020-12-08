using RRFFilesManager.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RRFFilesManager.DataAccess.Abstractions
{
    public interface IMobileCarrierRepository
    {
        Task InsertAsync(MobileCarrier mobileCarrier);
        Task UpdateAsync(MobileCarrier mobileCarrier);
        Task SoftDelteAsync(int mobileCarrierId);
        Task<MobileCarrier> GetByIdAsync(int mobileCarrierId);
        Task<IEnumerable<MobileCarrier>> ListAsync();
    }
}
