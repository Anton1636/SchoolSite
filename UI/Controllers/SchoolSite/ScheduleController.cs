using AutoMapper;
using BLL.Services.Abstraction;
using DAL.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UI.Models;

namespace UI.Controllers.SchoolSite
{
    public class ScheduleController : Controller
    {
        private readonly IScheduleService scheduleService;
        private readonly IMapper mapper;

        public ScheduleController(IScheduleService service, IMapper _mapper)
        {
            scheduleService = service;
            mapper = _mapper;
        }

        public ActionResult Home()
        {
            return View();
        }

        // GET: News
        public ActionResult Index()
        {
            List<tblSchedule> schedule = scheduleService.GetAllSchedule().ToList();
            var scheduleViewModel = mapper.Map<ICollection<ScheduleViewModel>>(schedule);
            return View(scheduleViewModel);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Create(ScheduleViewModel model, HttpPostedFileBase imageFile)
        {
            if (ModelState.IsValid)
            {
                var schedule = mapper.Map<tblSchedule>(model);
                scheduleService.AddSchedule(schedule);

                return RedirectToAction("Index");
            }
            return Create();
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var schedule = scheduleService.GetSchedule(id);
            return View(mapper.Map<ScheduleViewModel>(schedule));
        }

        [HttpPost]
        public ActionResult Edit(ScheduleViewModel model)
        {
            if (ModelState.IsValid)
            {
                var schedule = mapper.Map<tblSchedule>(model);
                scheduleService.Update(schedule);
                return RedirectToAction("Index");
            }
            return Edit(model.Id);
        }

        [HttpPost]
        public ActionResult Delete(int id)
        {
            var filePath = Server.MapPath("~/Content/img/" + scheduleService.GetSchedule(id));
            if (System.IO.File.Exists(filePath))
            {
                System.IO.File.Delete(filePath);
            }
            scheduleService.Delete(id);
            return RedirectToAction("Index");
        }
    }
}