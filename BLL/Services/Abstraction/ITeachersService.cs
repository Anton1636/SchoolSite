using DAL.Entity;
using System.Collections.Generic;

namespace BLL.Services.Abstraction
{
    public interface ITeachersService
    {
        ICollection<tblTeachers> GetAllTeachers();
        void AddTeachers(tblTeachers teachers);
        tblTeachers GetTeachers(int id);
        void Delete(int id);
        void Update(tblTeachers teachers);
    }
}
