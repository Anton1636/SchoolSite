using BLL.Services.Abstraction;
using DAL.Abstraction;
using DAL.Entity;
using System.Collections.Generic;
using System.Linq;

namespace BLL.Services
{
    public class CareerService : ICarrerService
    {
        private readonly IGenericRepository<tblCareer> repos;

        public CareerService(IGenericRepository<tblCareer> _repos)
        {
            repos = _repos;
        }

        public void AddCarrer(tblCareer career)
        {
            repos.Create(career);
        }

        public void Delete(int id)
        {
            repos.Delete(repos.Find(id));
        }

        public List<tblCareer> GetAllCarrer()
        {
            return repos.GetAll().ToList();
        }

        public tblCareer GetCarrer(int id)
        {
            return repos.Find(id);
        }

        public void Update(tblCareer career)
        {
            var found = repos.Find(career.Id);
            found = career;
            repos.Update(found);
        }
    }
}
