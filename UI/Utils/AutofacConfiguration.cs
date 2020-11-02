using Autofac;
using Autofac.Integration.Mvc;
using AutoMapper;
using BLL.Services;
using BLL.Services.Abstraction;
using DAL.Abstraction;
using DAL.Implementation;
using Google;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

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
            builder.RegisterType<ApplicationContext>().As<DbContext>().SingleInstance();
            builder.RegisterGeneric(typeof(EFrepository<>)).As(typeof(IGenericRepository<>));
            builder.RegisterType<CareerService>().As<ICarrerService>();
            builder.RegisterType<GallaryService>().As<IGallaryService>();

            // Register Mapper
            var mapperConfig = new MapperConfiguration(x => x.AddProfile(new MapperConfig()));
            builder.RegisterInstance<IMapper>(mapperConfig.CreateMapper());

            // 4. 
            DependencyResolver.SetResolver(new AutofacDependencyResolver(builder.Build()));
        }
    }
}