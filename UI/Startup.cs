using Autofac;
using Autofac.Integration.Mvc;
using AutoMapper;
using BLL.Services;
using BLL.Services.Abstraction;
using DAL;
using DAL.Abstraction;
using DAL.Implementation;
using DAL.Services.Abstraction;
using Microsoft.AspNet.Identity;
using Microsoft.Owin;
using Microsoft.Owin.Security.Cookies;
using Owin;
using System.Data.Entity;
using System.Web.Mvc;
using UI.Utils;

[assembly: OwinStartupAttribute(typeof(UI.Startup))]
namespace UI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            //app.CreatePerOwinContext<DbContext>(() => new ApplicationContext());
            //app.CreatePerOwinContext<AppUserManager>(AppUserManager.Create);
            //app.CreatePerOwinContext<UserSignInManager>(UserSignInManager.Create);
            //app.UseCookieAuthentication(new CookieAuthenticationOptions
            //{
            //    AuthenticationType = DefaultAuthenticationTypes.ApplicationCookie,
            //    LoginPath = new PathString("/Auth/Login")
            //});


            var builder = new ContainerBuilder();

            builder.RegisterControllers(typeof(MvcApplication).Assembly);
            builder.RegisterType<ApplicationContext>().As<DbContext>().SingleInstance();
            builder.RegisterGeneric(typeof(EFrepository<>)).As(typeof(IGenericRepository<>));

            builder.RegisterType<CareerService>().As<ICarrerService>();
            builder.RegisterType<GallaryService>().As<IGallaryService>();
            builder.RegisterType<NewsService>().As<INewsService>();
            builder.RegisterType<ScheduleService>().As<IScheduleService>();
            builder.RegisterType<ScoolPartyService>().As<ISchoolPartyService>();
            builder.RegisterType<TeachersService>().As<ITeachersService>();

            var mapperConfig = new MapperConfiguration(x => x.AddProfile(new MapperConfig()));
            builder.RegisterInstance<IMapper>(mapperConfig.CreateMapper());

            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));

            app.UseAutofacMiddleware(container);
            app.UseAutofacMvc();

            ConfigureAuth(app);

            //AttachDbFilename =| DataDirectory |\aspnet - UI - 20200908075134.mdf;
        }
    }
}
