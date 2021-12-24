using HrrMrr.Business.PetAdvertTransaction;
using HrrMrr.Business.PetTypeTransaction;
using HrrMrr.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HrrMrr.Presentation.Controllers
{
    public class PetAdvertController : Controller
    {
        PetAdvertTransaction transaction = new PetAdvertTransaction();
        PetTypeTransaction petTypeTransaction = new PetTypeTransaction();
        //PetAdverts listeleme
        public IActionResult PetAdvertList()
        {
            var temp = transaction.GetPetAdvertList();
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
        [HttpPost]
        public ActionResult AddPetAdvert(PetAdverts model, IFormFile ImageFile,int PetTypeId)
        {
            model.UserId = Convert.ToInt32(Request.Cookies["kullaniciId"]);
            PetTypeId = model.PetTypeId;
            ImageFile = model.Image.ImageFile;
            model.PetAdvertId = 1;
            var deneme = transaction.AddPetAdvert(model, ImageFile,PetTypeId);
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

    }
}