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

        public async Task<CYATemplate> GetByIdAsync(int templateId)
        {
            var account = await _context.CYATemplates.FirstOrDefaultAsync(x => x.ID == templateId);

            return account;

        }

        public async Task InsertAsync(CYATemplate template)
        {
            _context.CYATemplates.Add(template);

            await _context.SaveChangesAsync();
        }



        public async Task<IEnumerable<CYATemplate>> ListAsync(int? matterTypeId = null, string typeOfTemplate = null)
        {
            IQueryable<CYATemplate> query = _context.CYATemplates;
            if (matterTypeId != null)
                query = query.Where(s => s.MatterType.ID == matterTypeId.Value);
            if (typeOfTemplate != null)
                query = query.Where(s => s.TypeOfTemplate == typeOfTemplate);
            return await query.ToListAsync();
        }


        public async Task SoftDelteAsync(int templateId)
        {
            var accountToDelete = await _context.CYATemplates.FindAsync(templateId);

            await _context.SaveChangesAsync();

        }

        public async Task UpdateAsync(CYATemplate template)
        {
            var trxCYATemplate = await GetByIdAsync(template.ID);
            _context.Entry(trxCYATemplate).CurrentValues.SetValues(template);
            await _context.SaveChangesAsync();

        }
    }
}
