using DAL.Entity;
using DAL.Initializer;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    class ApplicationContext : IdentityDbContext<IdentityUser>
    {
        public DbSet<tblCareer> Career { get; set; }
        public DbSet<tblGallary> Gallary { get; set; }
        public DbSet<tblNews> News { get; set; }
        public DbSet<tblSchedule> Schedule { get; set; }
        public DbSet<tblSchoolParty> SchoolParty { get; set; }
        public DbSet<tblTeachers> Teachers { get; set; }

        public ApplicationContext()
            : base("name=SchoolSiteConnectionString")
        {
            Database.SetInitializer(new SchoolSiteInitializer());
        }
       
    }
}
