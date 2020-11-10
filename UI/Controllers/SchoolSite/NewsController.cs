using AutoMapper;
using DAL.Entity;
using DAL.Services.Abstraction;
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

namespace UI.Controllers
{
    public class NewsController : Controller
    {
        private readonly INewsService newsService;
        private readonly IMapper mapper;

        public NewsController(INewsService service, IMapper _mapper)
        {
            newsService = service;
            mapper = _mapper;
        }

        public NewsController()
        {

        }

        public ActionResult Index()
        {
            List<tblNews> news = newsService.GetAllNews().ToList();
            var newsViewModel = mapper.Map<ICollection<NewsViewModel>>(news);

            return View(newsViewModel);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }


        [HttpPost]
        [Authorize(Roles = CustomRoles.Admin)]
        public ActionResult Create(NewsViewModel model, HttpPostedFileBase imageFile)
        {
            if (ModelState.IsValid)
            {
                var news = mapper.Map<tblNews>(model);
                news.LinkImage = SaveImage(imageFile);
                newsService.AddNews(news);

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
        [Authorize(Roles = CustomRoles.Manager)]
        public ActionResult Edit(int id)
        {
            var news = newsService.GetNews(id);
            return View(mapper.Map<NewsViewModel>(news));
        }

        [HttpPost]
        public ActionResult Edit(NewsViewModel model)
        {
            if (ModelState.IsValid)
            {
                var news = mapper.Map<tblNews>(model);
                newsService.Update(news);
                return RedirectToAction("Index");
            }
            return Edit(model.Id);
        }

        [HttpPost]
        [Authorize(Roles = CustomRoles.Manager)]
        public ActionResult Delete(int id)
        {
            var filePath = Server.MapPath("~/Content/img/" + newsService.GetNews(id).LinkImage);
            if (System.IO.File.Exists(filePath))
            {
                System.IO.File.Delete(filePath);
            }
            newsService.Delete(id);
            return RedirectToAction("Index");
        }
    }
}