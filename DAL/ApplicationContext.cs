using DAL.Entity;
using DAL.Initializer;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;

namespace DAL
{
    public class ApplicationContext : IdentityDbContext<IdentityUser>
    {
        public DbSet<tblCareer> Career { get; set; }
        public DbSet<tblGallary> Gallary { get; set; }
        public DbSet<tblNews> News { get; set; }
        public DbSet<tblSchedule> Schedule { get; set; }
        public DbSet<tblSchoolParty> SchoolParty { get; set; }
        public DbSet<tblTeachers> Teachers { get; set; }
        public DbSet<User> Userr { get; set; }
        public DbSet<Role> Roless { get; set; }

        public ApplicationContext()
            : base("name=ConnectionString")
        {
            Database.SetInitializer(new SchoolSiteInitializer());
        }
    }
}
