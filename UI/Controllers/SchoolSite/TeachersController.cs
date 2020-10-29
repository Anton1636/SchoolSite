using AutoMapper;
using BLL.Services.Abstraction;
using DAL.Entity;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UI.Models;

namespace UI.Controllers.SchoolSite
{
    public class TeachersController : Controller
    {
        private readonly ITeachersService teachersService;
        private readonly IMapper mapper;

        public TeachersController(ITeachersService service, IMapper _mapper)
        {
            teachersService = service;
            mapper = _mapper;
        }

        public ActionResult Home()
        {
            return View();
        }

        // GET: News
        public ActionResult Index()
        {
            List<tblTeachers> teachers = teachersService.GetAllTeachers().ToList();
            var teachersViewModel = mapper.Map<ICollection<TeachersViewModel>>(teachers);
            return View(teachersViewModel);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Create(TeachersViewModel model, HttpPostedFileBase imageFile)
        {
            if (ModelState.IsValid)
            {
                var teachers = mapper.Map<tblTeachers>(model);
                teachers.ImageLink = SaveImage(imageFile);
                teachersService.AddTeachers(teachers);

                return RedirectToAction("Index");
            }
            return Create();
        }

        public string SaveImage(HttpPostedFileBase imageFile)
        {
            string fileName = Guid.NewGuid().ToString() + ".jpg";
            string fullPathImage = Path.GetFullPath(imageFile.FileName);
            using (Bitmap bmp = new Bitmap(imageFile.InputStream))
            {
                var bitmap = new Bitmap(640, 480);

                for (var x = 0; x < bitmap.Width; x++)
                {
                    for (var y = 0; y < bitmap.Height; y++)
                    {
                        bitmap.SetPixel(x, y, Color.BlueViolet);
                    }
                }

                if (bitmap != null)
                {
                    bitmap.Save(fullPathImage, ImageFormat.Jpeg);
                    return fileName;
                }
            }
            return "no image";
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var teachers = teachersService.GetTeachers(id);
            return View(mapper.Map<TeachersViewModel>(teachers));
        }

        [HttpPost]
        public ActionResult Edit(TeachersViewModel model)
        {
            if (ModelState.IsValid)
            {
                var teachers = mapper.Map<tblTeachers>(model);
                teachersService.Update(teachers);
                return RedirectToAction("Index");
            }
            return Edit(model.Id);
        }

        [HttpPost]
        public ActionResult Delete(int id)
        {
            var filePath = Server.MapPath("~/Content/img/" + teachersService.GetTeachers(id).ImageLink);
            if (System.IO.File.Exists(filePath))
            {
                System.IO.File.Delete(filePath);
            }
            teachersService.Delete(id);
            return RedirectToAction("Index");
        }
    }
}