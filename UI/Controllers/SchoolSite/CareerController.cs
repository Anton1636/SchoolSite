using AutoMapper;
using BLL.Services.Abstraction;
using DAL.Entity;
using System.Collections.Generic;
using System.Web;
using System.Web.Mvc;
using UI.Models;

namespace UI.Controllers.SchoolSite
{
    public class CareerController : Controller
    {
        private readonly ICarrerService careerService;
        private readonly IMapper mapper;

        public CareerController(ICarrerService service, IMapper _mapper)
        {
            careerService = service;
            mapper = _mapper;
        }

        public CareerController()
        {

        }

        public ActionResult Index()
        {
            List<tblCareer> career = careerService.GetAllCarrer();
            var careerViewModel = mapper.Map<ICollection<CareerViewModel>>(career);

            return View(careerViewModel);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Create(NewsViewModel model, HttpPostedFileBase imageFile)
        {
            if (ModelState.IsValid)
            {
                var career = mapper.Map<tblCareer>(model);
                careerService.AddCarrer(career);

                return RedirectToAction("Index");
            }
            return Create();
        }



        [HttpGet]
        public ActionResult Edit(int id)
        {
            var news = careerService.GetCarrer(id);
            return View(mapper.Map<NewsViewModel>(news));
        }

        [HttpPost]
        public ActionResult Edit(CareerViewModel model)
        {
            if (ModelState.IsValid)
            {
                var career = mapper.Map<tblCareer>(model);
                careerService.Update(career);
                return RedirectToAction("Index");
            }
            return Edit(model.Id);
        }

        [HttpPost]
        public ActionResult Delete(int id)
        {
            var filePath = Server.MapPath("~/Content/img/" + careerService.GetCarrer(id));
            if (System.IO.File.Exists(filePath))
            {
                System.IO.File.Delete(filePath);
            }
            careerService.Delete(id);
            return RedirectToAction("Index");
        }
    }
}