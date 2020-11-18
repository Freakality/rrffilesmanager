using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RRFFilesManager.Abstractions.DataAccess
{
    public interface IMatterTypeRepository
    {
        Task InsertAsync(MatterType matterType);
        Task UpdateAsync(MatterType matterType);
        Task SoftDelteAsync(int matterTypeId);
        Task<MatterType> GetByIdAsync(int matterTypeId);
        Task<IEnumerable<MatterType>> ListAsync();
    }
}
