using System.Collections.Generic;

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
