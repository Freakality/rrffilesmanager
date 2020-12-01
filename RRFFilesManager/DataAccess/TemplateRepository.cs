using RRFFilesManager.Abstractions;
using RRFFilesManager.Abstractions.DataAccess;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RRFFilesManager.DataAccess
{
    public class TemplateRepository : ITemplateRepository
    {
        private readonly DataContext _context;
        public TemplateRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<Template> GetByIdAsync(int templateId)
        {
            var template = await _context.Templates.FirstOrDefaultAsync(x => x.ID == templateId).ConfigureAwait(false);

            return template;

        }

        public async Task InsertAsync(Template template)
        {
            _context.Templates.Add(template);

            await _context.SaveChangesAsync().ConfigureAwait(false);
        }



        public async Task<IEnumerable<Template>> ListAsync(int? matterTypeId = null, string category = null, string typeOfTemplate = null)
        {
            IQueryable<Template> query = _context.Templates;
            if (matterTypeId != null)
                query = query.Where(s => s.MatterType.ID == matterTypeId.Value);
            if (typeOfTemplate != null)
                query = query.Where(s => s.TypeOfTemplate == typeOfTemplate);
            if (category != null)
                query = query.Where(s => s.Category == category);
            return await query.ToListAsync().ConfigureAwait(false);
        }


        public async Task SoftDelteAsync(int templateId)
        {
            var templateToDelete = await GetByIdAsync(templateId);

            await _context.SaveChangesAsync().ConfigureAwait(false);

        }

        public async Task UpdateAsync(Template template)
        {
            var trxCYATemplate = await GetByIdAsync(template.ID);
            _context.Entry(trxCYATemplate).CurrentValues.SetValues(template);
            await _context.SaveChangesAsync().ConfigureAwait(false);

        }
    }
}
