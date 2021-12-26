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
                List<PetAdverts> petAdvertsList = db.PetAdverts.Include(x => x.PetType).Include(x=>x.User)
                    .ToList();
                return petAdvertsList;
            }
        }


        public List<PetAdverts> GetMyPetAdvertList(int userId)
        {
            using (var db = new DatabaseContext())
            {
                List<PetAdverts> petAdvertsList = db.PetAdverts.Where(x=>x.UserId==userId).Include(x => x.PetType)
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

            }
        }

        public int GetLastId()
        {
            using (var db = new DatabaseContext())
            {
                int lastId = db.PetAdverts.Max(x => x.PetAdvertId);
                return lastId;
            }
        }

        public PetAdverts PetAdvertDetails(int id)
        {
            using (var db = new DatabaseContext())
            {
                var Detail = db.PetAdverts.Where(x => x.PetAdvertId == id).Include(x => x.PetType).Include
                                                            (x => x.User).
                                                            FirstOrDefault();
                return Detail;
            }
        }
    }
}