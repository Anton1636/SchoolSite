using AutoMapper;
using DAL.Entity;
using UI.Models;

namespace UI.Utils
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {
            CreateMap<tblCareer, CareerViewModel>();
            CreateMap<CareerViewModel, tblCareer > ();

            CreateMap<tblGallary, GallaryViewModel>();
            CreateMap<GallaryViewModel, tblGallary>();

            CreateMap<tblNews, NewsViewModel>();
            CreateMap<NewsViewModel, tblNews>();

            CreateMap<tblSchedule, ScheduleViewModel>();
            CreateMap<ScheduleViewModel, tblSchedule>();

            CreateMap<tblSchoolParty, SchoolPartyViewModel>();
            CreateMap<SchoolPartyViewModel, tblSchoolParty>();

            CreateMap<tblTeachers, TeachersViewModel>();
            CreateMap<TeachersViewModel, tblTeachers>();
        }
    }
}