using HrrMrr.Business.UserTransaction;
using HrrMrr.Entities;
using Microsoft.AspNetCore.Http;
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
       
        [HttpGet]
        public IActionResult RegisterCompany()
        {
            return View();
        }
        [HttpPost]
        public IActionResult RegisterCompany(Users user, string password,string password2)
        {
            var deneme = transaction.Register(user, password,password2);

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

        [HttpGet]
        public IActionResult RegisterUser()
        {
            return View();
        }
        [HttpPost]
        public IActionResult RegisterUser(Users user, string password, string password2)
        {
            var deneme = transaction.Register(user, password, password2);

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


        [HttpGet]
        public IActionResult Login()
        {
            var model = new Users();
            return View(model);
        }
        [HttpPost]
        public IActionResult Login(Users model)
        {
            var deneme = transaction.UserInformationControl(model.Mail, model.Password);
            if (deneme.IsSuccess == true)
            {
                Users user = transaction.User(model.Mail, model.Password);
                CookieOptions cookies = new CookieOptions();
                cookies.Expires = DateTime.Now.AddDays(21);
                Response.Cookies.Append("kullaniciAdi",user.Name+user.Surname);
                int denemeInt = user.UserId;
                Response.Cookies.Append("roleId", user.RoleId.ToString());
                Response.Cookies.Append("kullaniciId", denemeInt.ToString());
                return RedirectToAction("Index", "Home");
                
            }
            else
            {
                ViewBag.hataMesaji = deneme.Message[0];
                ViewBag.turu = deneme.Message[1];
                return View();
            }
        }

        public async Task<IActionResult> LogOut()
        {
            ViewBag.kullaniciGiris = null;
            if (Request.Cookies["kullaniciAdi"] != null)
            {
                Response.Cookies.Delete("kullaniciAdi");
                Response.Cookies.Delete("kullaniciId");
                Response.Cookies.Delete("roleId");
            }
            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public IActionResult MyAccount(int userid)
        {
             userid = Convert.ToInt32(Request.Cookies["kullaniciId"]);

             ViewBag.kullaniciId = Request.Cookies["kullaniciId"];
             ViewBag.roleId = Request.Cookies["roleId"];
            
            return View(transaction.MyAccount(userid));
        }


        [HttpGet]
        public IActionResult GetAccount(int id)
        {
            ViewBag.kullaniciId = Request.Cookies["kullaniciId"];
            ViewBag.roleId = Request.Cookies["roleId"];
            return View(transaction.GetAccount(id));
        }
    }
}
