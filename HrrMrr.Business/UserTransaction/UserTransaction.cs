using HrrMrr.DataAccess.Manager;
using HrrMrr.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using Utilities;
using Utilities.BusinessResult;

namespace HrrMrr.Business.UserTransaction
{
    public class UserTransaction
    {
        UserManager manager = new UserManager();

        public DataResult<object> Register(Users user, string password)
        {
            var result = new DataResult<object>();

            if (user.Mail == null)
            {
                result.Message.Add("Mail adresi alanı zorunludur.");
                result.Message.Add("danger");
                return result;
            }

            if (user.Name == null)
            {
                result.Message.Add("Ad alanı zorunludur.");
                result.Message.Add("danger");
                return result;
            }
            if (user.Surname == null)
            {
                result.Message.Add("Soyad alanı zorunludur.");
                result.Message.Add("danger");
                return result;
            }
            if (user.Password == null)
            {
                result.Message.Add("Parola alanı zorunludur.");
                result.Message.Add("danger");
                return result;
            }


            if (!RegexValidator.IsValidEmail(user.Mail))
            {
                result.Message.Add("Lütfen geçerli bir mail adresi giriniz.");
                result.Message.Add("danger");
                return result;

            }

            if (!RegexValidator.IsValidPassword(password))
            {
                result.Message.Add("Şifre, en az sekiz en fazla 10 karakter, en az bir büyük harf, bir küçük harf, bir sayı ve bir özel karakter(@$!%*?&.) içermelidir.");
                result.Message.Add("danger");
                return result;
            }


            //if (manager.UserControl(user.Mail) != null)
            //{
            //    result.Message.Add("Bu bilgilerle kaydolmuş bir kullanıcımız mevcut.");
            //    result.Message.Add("danger");
            //    return result;
            //}

            manager.RegisterCompany(user, password);
            result.IsSuccess = true;
            return result;
        }
    }
}
