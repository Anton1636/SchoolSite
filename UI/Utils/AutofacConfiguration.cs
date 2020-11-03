using Autofac;
using Autofac.Integration.Mvc;
using AutoMapper;
using BLL.Services;
using BLL.Services.Abstraction;
using DAL.Abstraction;
using DAL.Implementation;
using System.Data.Entity;
using System.Web.Mvc;
using DAL.Services.Abstraction;
using DAL;

namespace UI.Utils
{
    public class AutofacConfiguration
    {
        public static void ConfigurateAutofac()
        {
            // 1. Builder
            // 2. Register all controllers in assembly
            // 3. Register types
            // 4. Resolve -> build container
            // 5. start this method

            // 1.
            var builder = new ContainerBuilder();
            // 2.
            builder.RegisterControllers(typeof(MvcApplication).Assembly);
            //3.
            //builder.RegisterType<DAL.>().As<DbContext>().SingleInstance();
            builder.RegisterGeneric(typeof(EFrepository<>)).As(typeof(IGenericRepository<>));
            builder.RegisterType<CareerService>().As<ICarrerService>();
            builder.RegisterType<GallaryService>().As<IGallaryService>();
            builder.RegisterType<NewsService>().As<INewsService>();
            builder.RegisterType<ScheduleService>().As<IScheduleService>();
            builder.RegisterType<ScoolPartyService>().As<ISchoolPartyService>();
            builder.RegisterType<TeachersService>().As<ITeachersService>();

            // Register Mapper
            var mapperConfig = new MapperConfiguration(x => x.AddProfile(new MapperConfig()));
            builder.RegisterInstance<IMapper>(mapperConfig.CreateMapper());

            // 4. 
            DependencyResolver.SetResolver(new AutofacDependencyResolver(builder.Build()));
        }
    }
}