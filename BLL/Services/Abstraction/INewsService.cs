using DAL.Entity;
using System.Collections.Generic;

namespace DAL.Services.Abstraction
{
    public interface INewsService
    {
        ICollection<tblNews> GetAllNews();
        void AddNews(tblNews news);
        tblNews GetNews(int id);
        void Delete(int id);
        void Update(tblNews news);
    }
}
