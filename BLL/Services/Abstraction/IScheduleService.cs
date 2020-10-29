using DAL.Entity;
using System.Collections.Generic;

namespace BLL.Services.Abstraction
{
    public interface IScheduleService
    {
        ICollection<tblSchedule> GetAllSchedule();
        void AddSchedule(tblSchedule schedule);
        tblSchedule GetSchedule(int id);
        void Delete(int id);
        void Update(tblSchedule schedule);
    }
}
