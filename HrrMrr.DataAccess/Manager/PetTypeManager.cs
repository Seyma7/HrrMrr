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

        public void EditType(PetTypes _model)
        {
            using (var db = new DatabaseContext())
            {
                PetTypes type = db.PetTypes.Where(x => x.PetTypeId == _model.PetTypeId).FirstOrDefault();

                if (type != null)
                {
                    type.TypeName = _model.TypeName;

                    db.SaveChanges();
                }
            }
        }

        public void DeleteType(int? id)
        {
            using (var db = new DatabaseContext())
            {
                PetTypes type = db.PetTypes.Where(x => x.PetTypeId == id).FirstOrDefault();

                db.PetTypes.Remove(type);
                db.SaveChanges();
            }
        }

        public void AddType(PetTypes _model)
        {
            using (var db = new DatabaseContext())
            {
                db.PetTypes.Add(_model);
                db.SaveChanges();
            }
        }

        public List<PetTypes> Search(string searchString)
        {
            using (var db = new DatabaseContext())
            {
                var types = db.PetTypes.Where(x => x.TypeName.ToLower().Contains(searchString.ToLower()))
                                                                    .ToList();

                var petTypes = new List<PetTypes>();

                foreach (var item in types)
                {
                    var deneme = new PetTypes();
                    deneme = item;
                    petTypes.Add(deneme);
                }

                return types;
            }
        }

    }
}
