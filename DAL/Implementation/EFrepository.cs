using DAL.Abstraction;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;

namespace DAL.Implementation
{
    public class EFrepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        private readonly DbContext context;
        private readonly DbSet<TEntity> set;

        public EFrepository(DbContext _context)
        {
            context = _context;
            set = context.Set<TEntity>();
        }

        public void Save()
        {
            context.SaveChanges();
        }

        public void Create(TEntity entity)
        {
            set.Add(entity);
            Save();
        }

        public void Delete(TEntity entity)
        {
            set.Remove(entity);
            Save();
        }

        public TEntity Find(int id)
        {
            return set.Find(id);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return set.AsEnumerable();
        }

        public void Update(TEntity entity)
        {
            set.AddOrUpdate(entity);
            Save();
        }
    }
}
