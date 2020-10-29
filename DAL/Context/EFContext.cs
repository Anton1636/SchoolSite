using DAL.Entity;
using System.Data.Entity;

namespace DAL.Context
{
    public class EFContext : DbContext
    {
        public EFContext() : base("ConnectionString") {   }

        public DbSet<tblNews> Newss { get; set; }
        public DbSet<tblCareer> Careers { get; set; }
        public DbSet<tblTeachers> Teachers { get; set; }
        public DbSet<tblGallary> Gallaries { get; set; }
        public DbSet<tblSchedule> Schedules { get; set; }
        public DbSet<tblSchoolParty> SchoolParties { get; set; }
    }
}
