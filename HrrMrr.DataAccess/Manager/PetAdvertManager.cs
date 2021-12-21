using HrrMrr.Entities;
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
                List<PetAdverts> petAdvertsList = db.PetAdverts.ToList();
                return petAdvertsList;
            }
        }
    }
}