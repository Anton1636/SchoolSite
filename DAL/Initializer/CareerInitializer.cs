using DAL.Context;
using DAL.Entity;
using System.Collections.Generic;
using System.Data.Entity;

namespace DAL.Initializer
{
    public class CareerInitializer : DropCreateDatabaseAlways<EFContext>
    {
        protected override void Seed(EFContext _context)
        {
            var careers = new List<tblCareer>
            {
                new tblCareer{ Name = "Head Teacher", Salary = 20, Description = "Responsibilities: planning and organization of the educational process (drawing up curricula, timetables, load distribution)quality control of the educational processtraining, adaptation, assessment and organization of teachers' workorganization and control of student progress and attendance."},
                new tblCareer{ Name = "School cook", Salary = 250, Description = "Responsibilities: to be a team player, part of our team.Great desire to develop in this direction.Preparation of dishes and preparations according to the calculation, production technology and time standards in the Eurasia network.Maintaining cleanliness and order in the workplace in accordance with approved standards."},
                new tblCareer{ Name = "Watcher", Salary = 150, Description = "Responsibilities: checkpoint mode, ability to communicate, react quickly, think positively :) age is not an obstacle to the desire to work"},
                new tblCareer{ Name = "Scrubwoman", Salary = 175, Description = "Responsibilities: tidy up and clean up and clean it up in a proper sanitary camp, anchored in the back room - one room, wipe it down for a day (the robot is not folding, it’s clean in the back room, the school is okay, it’s good enough for the client company)" }
            };

            _context.Careers.AddRange(careers);
            _context.SaveChanges();
            base.Seed(_context);
        }
    }
}
