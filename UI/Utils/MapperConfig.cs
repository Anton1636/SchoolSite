using AutoMapper;
using DAL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UI.Models;

namespace UI.Utils
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {
            CreateMap<tblCareer, CareerViewModel>();
            CreateMap<tblGallary, GallaryViewModel>();
            CreateMap<tblNews, NewsViewModel>();
            CreateMap<tblSchedule, ScheduleViewModel>();
            CreateMap<tblSchoolParty, SchoolPartyViewModel>();
            CreateMap<tblTeachers, TeachersViewModel>();
        }
    }
}