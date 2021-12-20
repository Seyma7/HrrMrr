using HrrMrr.DataAccess.Manager;
using HrrMrr.Entities;
using Utilities.BusinessResult;

namespace HrrMrr.Business.UserTransaction
{
    public class UserTransaction
    {
        UserManager manager = new UserManager();

        public DataResult<object> Register(Users user, string password,string password2)
        {
            var result = new DataResult<object>();

            if (user.Mail == null)
            {
                result.Message.Add("Mail adresi alanı zorunludur.");
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
            if (password!=password2)
            {
                result.Message.Add("Parolalar eşleşmiyor.");
                result.Message.Add("danger");
                return result;
            }

            if (manager.UserControl(user.Mail) != null)
            {
                result.Message.Add("Bu bilgilerle kaydolmuş bir kullanıcımız mevcut.");
                result.Message.Add("danger");
                return result;
            }

            manager.RegisterUser(user, password);
            result.IsSuccess = true;
            return result;
        }

        public DataResult<object> UserInformationControl(string mail, string password)
        {
            var result = new DataResult<object>();

            if (manager.UserInformationControl(mail, password) == null)
            {
                result.Message.Add("Kullanıcı bilgileriniz hatalıdır.");
                result.Message.Add("danger");
                return result;
            }
            result.IsSuccess = true;
            return result;
        }

        //Kulanıcı adı ve şifre kontrolü
        public Users User(string mail, string password)
        {
            return manager.User(mail, password);
        }
    }
}
