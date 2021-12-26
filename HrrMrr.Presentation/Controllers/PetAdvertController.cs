using HrrMrr.Business.PetAdvertTransaction;
using HrrMrr.Business.PetTypeTransaction;
using HrrMrr.Entities;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace HrrMrr.Presentation.Controllers
{
    public class PetAdvertController : Controller
    {
        PetAdvertTransaction transaction = new PetAdvertTransaction();
        PetTypeTransaction petTypeTransaction = new PetTypeTransaction();
        private readonly IWebHostEnvironment _hostEnvironment;

        public PetAdvertController(IWebHostEnvironment hostEnvironment)
        {
            this._hostEnvironment = hostEnvironment;
        }

        //PetAdverts listeleme
        public IActionResult PetAdvertList()
        {
            var temp = transaction.GetPetAdvertList();
            return View(temp);
        }


        public IActionResult MyPetAdvertList()
        {
            if (Request.Cookies["kullaniciId"] == null)
            {
                ViewBag.kullaniciGiris = null;

            }
            else
                ViewBag.kullaniciGiris = Request.Cookies["kullaniciId"];
            int userId= Convert.ToInt32(Request.Cookies["kullaniciId"]);
            var temp = transaction.GetMyPetAdvertList(userId);
            return View(temp);
        }

        //Add new blog.
        [HttpGet]
        public ActionResult AddPetAdvert()
        {
            if (Request.Cookies["kullaniciAdi"] == null)
            {
                ViewBag.kullaniciGiris = null;

            }
            else
                ViewBag.kullaniciGiris = Request.Cookies["kullaniciAdi"];
            var types=petTypeTransaction.GetPetTypeList();
            ViewBag.petTypes = types;
            return View();
        }
        [ValidateAntiForgeryToken]
        [HttpPost]
        public async Task<IActionResult> AddPetAdvert(PetAdverts model,int PetTypeId)
        {
            model.UserId = Convert.ToInt32(Request.Cookies["kullaniciId"]);
            PetTypeId = model.PetTypeId;

            int lastId = transaction.GetLastId();
            string xd = (lastId + 1).ToString();

            string wwwRootPath = _hostEnvironment.WebRootPath;
            string fileName = Path.GetFileNameWithoutExtension(xd);
            string extension= Path.GetExtension(model.ImageFile.FileName);
            fileName = fileName + extension;
            string path = Path.Combine(wwwRootPath + "/image", fileName);
            using (var filestream=new FileStream(path,FileMode.Create))
            {
                await model.ImageFile.CopyToAsync(filestream);
            }
            
            var deneme = transaction.AddPetAdvert(model,PetTypeId);
           
            if (deneme.IsSuccess == true)
            {
                return RedirectToAction("MyPetAdverts");
            }
            else
            {
                ViewBag.hataMesaji = deneme.Message[0];
                ViewBag.turu = deneme.Message[1];
                return View();
            }
        }

        [HttpGet]
        public ActionResult PetAdvertDetails(int id)
        {
            return View(transaction.PetAdvertDetails(id));
        }
    }
}