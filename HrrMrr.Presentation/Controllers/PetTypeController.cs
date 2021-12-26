using HrrMrr.Business.PetTypeTransaction;
using HrrMrr.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HrrMrr.Presentation.Controllers
{
    public class PetTypeController : Controller
    {
        PetTypeTransaction transaction = new PetTypeTransaction();
        public IActionResult PetTypes()
        {
            return View(transaction.GetPetTypeList());
        }

        public IActionResult EditType(PetTypes _model)
        {
            transaction.EditType(_model);
            return RedirectToAction("PetTypes","PetType");
        }

        //Delete Category
        public ActionResult DeleteType(int? id)
        {
            if (id != null)
            {
                transaction.DeleteType(id);
                return RedirectToAction("PetTypes", "PetType");
            }
            else
            {
                return RedirectToAction("PetTypes", "PetType");
            }
        }


        public ActionResult AddType(PetTypes _model)
        {
            transaction.AddType(_model);
            return RedirectToAction("PetTypes");
        }

        public IActionResult Search(string searchString)
        {
            var typeList = transaction.Search(searchString);
            return View("PetTypes", typeList);
        }
    }
}
