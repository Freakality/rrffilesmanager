using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RRFFilesManager.Abstractions.DataAccess
{
    public interface IMatterSubTypeRepository
    {
        Task InsertAsync(MatterSubType matterSubType);
        Task UpdateAsync(MatterSubType matterSubType);
        Task SoftDelteAsync(int matterSubTypeId);
        Task<MatterSubType> GetByIdAsync(int matterSubTypeId);
        Task<IEnumerable<MatterSubType>> ListAsync();
    }
}
