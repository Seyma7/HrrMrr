using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HrrMrr.Presentation.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            if (Request.Cookies["kullaniciAdi"] == null)
            {
                ViewBag.kullaniciGiris = null;

            }
            else
            {
                ViewBag.kullaniciGiris = Request.Cookies["kullaniciAdi"];
                ViewBag.roleId = Request.Cookies["roleId"];
            }
                
                
            return View();
        }
    }
}
