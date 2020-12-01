using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RRFFilesManager.Abstractions.DataAccess
{
    public interface ITemplateRepository
    {
        Task InsertAsync(Template template);
        Task UpdateAsync(Template template);
        Task SoftDelteAsync(int templateId);
        Task<Template> GetByIdAsync(int templateId);
        Task<IEnumerable<Template>> ListAsync(int? matterTypeId = null, string category = null, string typeOfTemplate = null);
    }
}
