using HrrMrr.DataAccess.Manager;
using HrrMrr.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HrrMrr.Business.PetAdvertTransaction
{
    public class PetAdvertTransaction
    {
        PetAdvertManager manager = new PetAdvertManager();

        public List<PetAdverts> GetPetAdvertList()
        {
            return manager.GetPetAdvertList();
        }

    }
}
