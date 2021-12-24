using HrrMrr.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HrrMrr.DataAccess.Manager
{
    public class PetTypeManager
    {
        public List<PetTypes> GetPetTypeList()
        {
            using (var db = new DatabaseContext())
            {
                List<PetTypes> petTypeList = db.PetTypes
                    .ToList();
                return petTypeList;
            }
                
        }

    }
}
