using DAL.Context;
using DAL.Entity;
using System.Collections.Generic;
using System.Data.Entity;

namespace DAL.Initializer
{
    public class ScheduleInitializer : DropCreateDatabaseAlways<EFContext>
    {
        protected override void Seed(EFContext _context)
        {
            var schedule = new List<tblSchedule>
            {
                new tblSchedule{ SubjectName = "Maths", TeacherName = "Makarchuk Zoya Vladimirovna", DayWeek = "Moday", StartTime = "11:00", EndTime = "11:40"},
                new tblSchedule{ SubjectName = "World Literature", TeacherName = "Ordynska Vira Hryhorivna", DayWeek = "Moday", StartTime = "12:00", EndTime = "12:40"},
                new tblSchedule{ SubjectName = "Labor training and technology", TeacherName = "Yaremchuk Irina Petrovna", DayWeek = "Moday", StartTime = "13:00", EndTime = "13:40"},
                new tblSchedule{ SubjectName = "German language", TeacherName = "Dubych Iryna Mykhailivna", DayWeek = "Moday", StartTime = "14:00", EndTime = "14:40"},
                new tblSchedule{ SubjectName = "Musical art", TeacherName = "Yatsenya Alla Vladimirovna", DayWeek = "Moday", StartTime = "15:00", EndTime = "15:40"},
                new tblSchedule{ SubjectName = "Physical education and swimming", TeacherName = "Kovaleva Tatiana Nikolaevna", DayWeek = "Friday", StartTime = "11:00", EndTime = "11:40"},
                new tblSchedule{ SubjectName = "Ukrainian language", TeacherName = "Basyrova Nina Stepanovna", DayWeek = "Friday", StartTime = "12:00", EndTime = "12:40"},
                new tblSchedule{ SubjectName = "English language", TeacherName = "Malyarchuk Maria Andreevna", DayWeek = "Friday", StartTime = "13:00", EndTime = "13:40"},
                new tblSchedule{ SubjectName = "Computer science", TeacherName = "Smulka Victor Vasilyevich", DayWeek = "Friday", StartTime = "14:00", EndTime = "14:40"},
                new tblSchedule{ SubjectName = "Biology", TeacherName = "Pashko Halyna Ulyanivna", DayWeek = "Friday", StartTime = "15:00", EndTime = "15:40"}
            };

            _context.Schedules.AddRange(schedule);
            _context.SaveChanges();
            base.Seed(_context);
        }
    }
}
