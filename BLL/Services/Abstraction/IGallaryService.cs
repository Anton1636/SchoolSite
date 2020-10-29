using DAL.Entity;
using System.Collections.Generic;

namespace BLL.Services.Abstraction
{
    public interface IGallaryService
    {
        ICollection<tblGallary> GetAllGallary();
        void AddGallary(tblGallary gallary);
        tblGallary GetGallary(int id);
        void Delete(int id);
        void Update(tblGallary gallary);
    }
}
