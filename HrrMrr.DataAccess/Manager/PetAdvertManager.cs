using HrrMrr.Entities;
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

     
        public void AddPetAdvert(PetAdverts model)
        {
            using (var db = new DatabaseContext())
            {
                model.Date = DateTime.Now;

                var user = db.Users.Where(x => x.UserId == model.UserId).FirstOrDefault();
                model.User = user;
                
                db.PetAdverts.Add(model);
                db.SaveChanges();

                int lastId = db.PetAdverts.Max(x => x.PetAdvertId);

                if (model.Image != null)
                {
                        Images deneme = new Images();
                        deneme.ImageName = model.Image.ImageName;
                        deneme.PetAdvertId = lastId;
                        db.Images.Add(deneme);
                        db.SaveChanges();
                }
            }
        }
    }
}