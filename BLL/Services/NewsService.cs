using DAL.Abstraction;
using DAL.Entity;
using DAL.Services.Abstraction;
using System.Collections.Generic;
using System.Linq;

namespace BLL.Services
{
    public class NewsService : INewsService
    {
        private readonly IGenericRepository<tblNews> repos;

        public NewsService(IGenericRepository<tblNews> _repos)
        {
            repos = _repos;
        }

        public void AddNews(tblNews news)
        {
            repos.Create(news);
        }

        public void Delete(int id)
        {
            repos.Delete(repos.Find(id));
        }

        public ICollection<tblNews> GetAllNews()
        {
            return repos.GetAll().ToList();
        }

        public tblNews GetNews(int id)
        {
            return repos.Find(id);
        }

        public void Update(tblNews news)
        {
            var found = repos.Find(news.Id);
            found = news;
            repos.Update(found);
        }
    }
}
