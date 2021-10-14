using RRFFilesManager.Abstractions;
using RRFFilesManager.DataAccess.Abstractions;
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Text;


namespace RRFFilesManager.DataAccess
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity>
        where TEntity : Entity
    {
        private readonly DataContext _context;
        private readonly DbSet<TEntity> _set;
        public GenericRepository(DataContext context, DbSet<TEntity> set)
        {
            _context = context;
            _set = set;
        }

        public TEntity GetById(int entityId) => _set.FirstOrDefault(x => x.ID == entityId);

        public void Insert(TEntity entity)
        {
            _set.Add(entity);
            _context.SaveChanges();
        }

        public  IEnumerable<TEntity> List() => _set.ToList();

        public void SoftDelete(int entityId)
        {
            _set.Find(entityId);
            _context.SaveChanges();
        }

        public void Update(TEntity entity)
        {
            var trxEntity = GetById(entity.ID);
            _context.Entry(trxEntity).CurrentValues.SetValues(entity);
            _context.SaveChanges();

        }
    }
}
