using DAL.Entity;
using System.Collections.Generic;

namespace BLL.Services.Abstraction
{
    public interface ISchoolPartyService
    {
        ICollection<tblSchoolParty> GetAllSchoolParty();
        void AddSchoolParty(tblSchoolParty schoolParty);
        tblSchoolParty GetSchoolParty(int id);
        void Delete(int id);
        void Update(tblSchoolParty schoolParty);
    }
}
