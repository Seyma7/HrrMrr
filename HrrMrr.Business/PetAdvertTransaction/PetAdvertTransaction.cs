using HrrMrr.DataAccess.Manager;
using HrrMrr.Entities;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities.BusinessResult;

namespace HrrMrr.Business.PetAdvertTransaction
{
    public class PetAdvertTransaction
    {
        PetAdvertManager manager = new PetAdvertManager();

        public List<PetAdverts> GetPetAdvertList()
        {
            return manager.GetPetAdvertList();
        }

        public DataResult<object> AddPetAdvert(PetAdverts model, IFormFile imageFile, int PetTypeId)
        {
            var result = new DataResult<object>();

            if (model.Description == null)
            {
                result.Message.Add("Açıklama alanı zorunludur.");
                result.Message.Add("danger");
                return result;
            }
            if (model.Story == null)
            {
                result.Message.Add("Hikaye alanı zorunludur.");
                result.Message.Add("danger");
                return result;
            }
            if (model.Gender == null)
            {
                result.Message.Add("Cinsiyet alanı zorunludur.");
                result.Message.Add("danger");
                return result;
            }
            if (model.Location == null)
            {
                result.Message.Add("Adres alanı zorunludur.");
                result.Message.Add("danger");
                return result;
            }
            if (model.Image == null)
            {
                result.Message.Add("Görsel alanı zorunludur.");
                result.Message.Add("danger");
                return result;
            }
            if (PetTypeId == 0)
            {
                result.Message.Add("Evcil hayvanın türü alanı zorunludur.");
                result.Message.Add("danger");
                return result;
            }
            manager.AddPetAdvert(model,imageFile);
            result.IsSuccess = true;
            return result;
        }
    }
}
