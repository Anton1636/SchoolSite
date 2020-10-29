using BLL.Services.Abstraction;
using DAL.Abstraction;
using DAL.Entity;
using System.Collections.Generic;
using System.Linq;

namespace BLL.Services
{
    public class TeachersService : ITeachersService
    {
        private readonly IGenericRepository<tblTeachers> repos;

        public TeachersService(IGenericRepository<tblTeachers> _repos)
        {
            repos = _repos;
        }

        public void AddTeachers(tblTeachers teachers)
        {
            repos.Create(teachers);
        }

        public void Delete(int id)
        {
            repos.Delete(repos.Find(id));
        }

        public ICollection<tblTeachers> GetAllTeachers()
        {
            return repos.GetAll().ToList();
        }

        public tblTeachers GetTeachers(int id)
        {
            return repos.Find(id);
        }

        public void Update(tblTeachers teachers)
        {
            var found = repos.Find(teachers.Id);
            found = teachers;
            repos.Update(found);
        }
    }
}
