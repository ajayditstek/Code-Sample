using System;
using System.Collections.Generic;

namespace Demo.Core.IGenericRepo
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        IEnumerable<TEntity> GetAll();
        TEntity GetById(Guid id);
        void Insert(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity obj);
        IEnumerable<TEntity> GetAllConditional(string columnName, string value);
    }
}
