using HrrMrr.DataAccess.Manager;
using HrrMrr.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HrrMrr.Business.PetTypeTransaction
{
    public class PetTypeTransaction
    {
        PetTypeManager manager = new PetTypeManager();
        public List<PetTypes> GetPetTypeList()
        {
            return manager.GetPetTypeList();
        }
    }
}
