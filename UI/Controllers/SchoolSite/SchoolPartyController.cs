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
    public class SchoolPartyController : Controller
    {
        private readonly ISchoolPartyService schoolPartyService;
        private readonly IMapper mapper;

        public SchoolPartyController(ISchoolPartyService service, IMapper _mapper)
        {
            schoolPartyService = service;
            mapper = _mapper;
        }

        public SchoolPartyController()
        {

        }

        public ActionResult Index()
        {
            List<tblSchoolParty> sp = schoolPartyService.GetAllSchoolParty().ToList();
            var schoolPartyViewModel = mapper.Map<ICollection<SchoolPartyViewModel>>(sp);

            return View(schoolPartyViewModel);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }


        [HttpPost]
        [Authorize(Roles = CustomRoles.Admin)]
        public ActionResult Create(SchoolPartyViewModel model, HttpPostedFileBase imageFile)
        {
            if (ModelState.IsValid)
            {
                var sp = mapper.Map<tblSchoolParty>(model);
                sp.ImageLink = SaveImage(imageFile);
                schoolPartyService.AddSchoolParty(sp);

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
            var sp = schoolPartyService.GetSchoolParty(id);
            return View(mapper.Map<SchoolPartyViewModel>(sp));
        }

        [HttpPost]
        public ActionResult Edit(SchoolPartyViewModel model)
        {
            if (ModelState.IsValid)
            {
                var sp = mapper.Map<tblSchoolParty>(model);
                schoolPartyService.Update(sp);
                return RedirectToAction("Index");
            }
            return Edit(model.Id);
        }

        [HttpPost]
        [Authorize(Roles = CustomRoles.Manager)]
        public ActionResult Delete(int id)
        {
            var filePath = Server.MapPath("~/Content/img/" + schoolPartyService.GetSchoolParty(id).ImageLink);
            if (System.IO.File.Exists(filePath))
            {
                System.IO.File.Delete(filePath);
            }
            schoolPartyService.Delete(id);
            return RedirectToAction("Index");
        }
    }
}