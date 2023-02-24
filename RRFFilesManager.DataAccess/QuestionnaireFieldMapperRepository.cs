using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Text;
using RRFFilesManager.Abstractions;
using RRFFilesManager.DataAccess;
using RRFFilesManager.DataAccess.Abstractions;

namespace RRFFilesManager.DataAccess
{
    public class QuestionnaireFieldMapperRepository : IQuestionnaireFieldMapperRepository
    {
        private readonly DataContext _context;
        public QuestionnaireFieldMapperRepository(DataContext context)
        {
            _context = context;
        }

        public  QuestionnaireFieldMapper GetById(int id)
        {
            var result = _context.QuestionnaireFieldMappers.FirstOrDefault(x => x.ID == id);
            return result;
        }

        public void Insert(QuestionnaireFieldMapper entity)
        {
            _context.QuestionnaireFieldMappers.Add(entity);
            _context.SaveChanges();
        }

        public  IEnumerable<QuestionnaireFieldMapper> List()
        {
            return _context.QuestionnaireFieldMappers.ToList();
        }

        public void SoftDelete(int id)
        {
            var entityToDelete = GetById(id);
            _context.SaveChanges();
        }

        public void Delete(QuestionnaireFieldMapper entity)
        {
            var trxEntity = GetById(entity.ID);
            _context.QuestionnaireFieldMappers.Remove(trxEntity);
            _context.SaveChanges();
        }

        public void Update(QuestionnaireFieldMapper entity)
        {
            var trxEntity = GetById(entity.ID);
            _context.Entry(trxEntity).CurrentValues.SetValues(entity);
            _context.SaveChanges();
        }
        
    }
}
