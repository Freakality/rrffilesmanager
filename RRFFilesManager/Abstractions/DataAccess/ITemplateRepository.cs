using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RRFFilesManager.Abstractions.DataAccess
{
    public interface ITemplateRepository
    {
        Task InsertAsync(CYATemplate template);
        Task UpdateAsync(CYATemplate template);
        Task SoftDelteAsync(int templateId);
        Task<CYATemplate> GetByIdAsync(int templateId);
        Task<IEnumerable<CYATemplate>> ListAsync(int? matterTypeId = null, string typeOfTemplate = null);
    }
}
