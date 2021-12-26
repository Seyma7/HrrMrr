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

        public void EditType(PetTypes _model)
        {
            manager.EditType(_model);
        }

        public void DeleteType(int? id)
        {
            manager.DeleteType(id);
        }

        public void AddType(PetTypes _model)
        {
            manager.AddType(_model);
        }

        public List<PetTypes> Search(string searchString)
        {
            return manager.Search(searchString);
        }
    }
}
