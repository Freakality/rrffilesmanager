using RRFFilesManager.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace RRFFilesManager.DataAccess.Abstractions
{
    public interface IGenericRepository<T>
    {
        void Insert(T entity);
        void Update(T entity);
        void SoftDelete(int entityId);
        T GetById(int entityId);
        IEnumerable<T> List();
    }
}
