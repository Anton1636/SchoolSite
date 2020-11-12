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
using UI.Utils;

namespace UI.Controllers.SchoolSite
{
    public class GallaryController : Controller
    {
        private readonly IGallaryService gallaryService;
        private readonly IMapper mapper;

        public GallaryController(IGallaryService service, IMapper _mapper)
        {
            gallaryService = service;
            mapper = _mapper;
        }

        public GallaryController()
        {

        }

        [Authorize(Roles = "user")]
        public ActionResult Index()
        {
            List<tblGallary> gallary = gallaryService.GetAllGallary().ToList();
            var gallaryViewModel = mapper.Map<ICollection<GallaryViewModel>>(gallary);

            return View(gallaryViewModel);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }


        [HttpPost]
        [Authorize(Roles = "admin")]
        public ActionResult Create(GallaryViewModel model, HttpPostedFileBase imageFile)
        {
            if (ModelState.IsValid)
            {
                var gallary = mapper.Map<tblGallary>(model);
                gallary.ImageLink = SaveImage(imageFile);
                gallaryService.AddGallary(gallary);

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
            var gallary = gallaryService.GetGallary(id);
            return View(mapper.Map<GallaryViewModel>(gallary));
        }

        [HttpPost]
        [Authorize(Roles = "admin")]
        public ActionResult Edit(GallaryViewModel model)
        {
            if (ModelState.IsValid)
            {
                var gallary = mapper.Map<tblGallary>(model);
                gallaryService.Update(gallary);
                return RedirectToAction("Index");
            }
            return Edit(model.Id);
        }

        [HttpPost]
        [Authorize(Roles = "admin")]
        public ActionResult Delete(int id)
        {
            var filePath = Server.MapPath("~/Content/img/" + gallaryService.GetGallary(id).ImageLink);
            if (System.IO.File.Exists(filePath))
            {
                System.IO.File.Delete(filePath);
            }
            gallaryService.Delete(id);
            return RedirectToAction("Index");
        }
    }
}