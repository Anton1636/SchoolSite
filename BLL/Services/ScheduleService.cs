using BLL.Services.Abstraction;
using DAL.Abstraction;
using DAL.Entity;
using System.Collections.Generic;
using System.Linq;

namespace BLL.Services
{
    public class ScheduleService : IScheduleService
    {
        private readonly IGenericRepository<tblSchedule> repos;

        public ScheduleService(IGenericRepository<tblSchedule> _repos)
        {
            repos = _repos;
        }

        public void AddSchedule(tblSchedule schedule)
        {
            repos.Create(schedule);
        }

        public void Delete(int id)
        {
            repos.Delete(repos.Find(id));
        }

        public ICollection<tblSchedule> GetAllSchedule()
        {
            return repos.GetAll().ToList();
        }

        public tblSchedule GetSchedule(int id)
        {
            return repos.Find(id);
        }

        public void Update(tblSchedule schedule)
        {
            var found = repos.Find(schedule.Id);
            found = schedule;
            repos.Update(found);
        }
    }
}
