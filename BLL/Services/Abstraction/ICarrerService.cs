using DAL.Entity;
using System.Collections.Generic;

namespace BLL.Services.Abstraction
{
    public interface ICarrerService
    {
        List<tblCareer> GetAllCarrer();
        void AddCarrer(tblCareer career);
        tblCareer GetCarrer(int id);
        void Delete(int id);
        void Update(tblCareer career);
    }
}
