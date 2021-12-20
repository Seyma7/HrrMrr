using HrrMrr.Business.UserTransaction;
using HrrMrr.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HrrMrr.Presentation.Controllers
{
    public class UserController : Controller
    {
        UserTransaction transaction = new UserTransaction();
        public IActionResult Login()
        {
            return View();
        }

        [HttpGet]
        public IActionResult RegisterCompany()
        {
            return View();
        }
        [HttpPost]
        public IActionResult RegisterCompany(Users user, string password)
        {
            var deneme = transaction.Register(user, password);

            if (deneme.IsSuccess == true)
            {
                return RedirectToAction("Login", "User");
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
