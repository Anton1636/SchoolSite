using BLL.Services.Abstraction;
using DAL.Abstraction;
using DAL.Entity;
using System.Collections.Generic;
using System.Linq;

namespace BLL.Services
{
    public class GallaryService : IGallaryService
    {
        private readonly IGenericRepository<tblGallary> repos;

        public GallaryService(IGenericRepository<tblGallary> _repos)
        {
            repos = _repos;
        }

        public void AddGallary(tblGallary gallary)
        {
            repos.Create(gallary);
        }

        public void Delete(int id)
        {
            repos.Delete(repos.Find(id));
        }

        public ICollection<tblGallary> GetAllGallary()
        {
            return repos.GetAll().ToList();
        }

        public tblGallary GetGallary(int id)
        {
            return repos.Find(id);
        }

        public void Update(tblGallary gallary)
        {
            var found = repos.Find(gallary.Id);
            found = gallary;
            repos.Update(found);
        }
    }
}
