using BLL.Services.Abstraction;
using DAL.Abstraction;
using DAL.Entity;
using System.Collections.Generic;
using System.Linq;

namespace BLL.Services
{
    public class ScoolPartyService : ISchoolPartyService
    {
        private readonly IGenericRepository<tblSchoolParty> repos;

        public ScoolPartyService(IGenericRepository<tblSchoolParty> _repos)
        {
            repos = _repos;
        }

        public void AddSchoolParty(tblSchoolParty schoolParty)
        {
            repos.Create(schoolParty);
        }

        public void Delete(int id)
        {
            repos.Delete(repos.Find(id));
        }

        public ICollection<tblSchoolParty> GetAllSchoolParty()
        {
            return repos.GetAll().ToList();
        }

        public tblSchoolParty GetSchoolParty(int id)
        {
            return repos.Find(id);
        }

        public void Update(tblSchoolParty schoolParty)
        {
            var found = repos.Find(schoolParty.Id);
            found = schoolParty;
            repos.Update(found);
        }
    }
}
