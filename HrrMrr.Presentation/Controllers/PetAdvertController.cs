using HrrMrr.Business.PetAdvertTransaction;
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

        public IActionResult PetAdverts()
        {
            return View();
        }

        //Pagination yap
        //PetAdverts listeleme
        public IActionResult PetAdvertsList()
        {
            var temp = transaction.GetPetAdvertList();
            return View(temp);
        }
    }
}
