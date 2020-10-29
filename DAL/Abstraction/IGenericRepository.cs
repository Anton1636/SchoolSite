using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace DAL.Abstraction
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        void Create(TEntity entity);
        void Delete(TEntity entity);
        void Update(TEntity entity);
        IEnumerable<TEntity> GetAll();
        TEntity Find(int id);
    }
}
