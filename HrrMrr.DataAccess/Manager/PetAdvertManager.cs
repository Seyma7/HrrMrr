using HrrMrr.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HrrMrr.DataAccess.Manager
{
    public class PetAdvertManager
    {
        public List<PetAdverts> GetPetAdvertList()
        {
            using (var db = new DatabaseContext())
            {
                List<PetAdverts> petAdvertsList = db.PetAdverts.Include(x => x.PetType)
                    .ToList();
                return petAdvertsList;
            }
        }

     
        public void AddPetAdvert(PetAdverts model,IFormFile imageFile)
        {
            using (var db = new DatabaseContext())
            {
                model.Date = DateTime.Now;
                var user = db.Users.Where(x => x.UserId == model.UserId).FirstOrDefault();
                model.User = user;

                db.PetAdverts.Add(model);
                db.SaveChanges();

                int lastId = db.PetAdverts.Max(x => x.PetAdvertId);
                if (imageFile != null)
                {
                        Images deneme = new Images();
                        deneme.ImageFile =imageFile;
                        deneme.PetAdvertId = lastId;
                        db.Images.Add(deneme);
                        db.SaveChanges();
                }
            }
        }
    }
}