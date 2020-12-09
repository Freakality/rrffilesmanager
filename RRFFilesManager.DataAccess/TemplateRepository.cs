using RRFFilesManager.Abstractions;
using RRFFilesManager.DataAccess.Abstractions;
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Text;


namespace RRFFilesManager.DataAccess
{
    public class TemplateRepository : ITemplateRepository
    {
        private readonly DataContext _context;
        public TemplateRepository(DataContext context)
        {
            _context = context;
        }

        public  Template GetById(int templateId)
        {
            var template = _context.Templates.FirstOrDefault(x => x.ID == templateId);

            return template;

        }

        public void Insert(Template template)
        {
            _context.Templates.Add(template);

            _context.SaveChanges();
        }



        public  IEnumerable<Template> List(int? matterTypeId = null, string category = null, string typeOfTemplate = null)
        {
            IQueryable<Template> query = _context.Templates;
            if (matterTypeId != null)
                query = query.Where(s => s.MatterType.ID == matterTypeId.Value);
            if (typeOfTemplate != null)
                query = query.Where(s => s.TypeOfTemplate == typeOfTemplate);
            if (category != null)
                query = query.Where(s => s.Category == category);
            return query.ToList();
        }

        public ICollection<string> GetCategories()
        {
            var categories = _context.Templates.Select(s => s.Category).Distinct();
            return categories.ToList();
        }

        public ICollection<string> GetTypesOfTemplate()
        {
            var typesOfTemplate = _context.Templates.Select(s => s.TypeOfTemplate).Distinct();
            return typesOfTemplate.ToList();
        }


        public void SoftDelete(int templateId)
        {
            var templateToDelete = GetById(templateId);

            _context.SaveChanges();

        }

        public void Update(Template template)
        {
            var trxCYATemplate = GetById(template.ID);
            _context.Entry(trxCYATemplate).CurrentValues.SetValues(template);
            _context.SaveChanges();

        }
    }
}
