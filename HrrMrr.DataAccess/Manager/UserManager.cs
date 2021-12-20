using HrrMrr.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VBM.Entity.MD5;

namespace HrrMrr.DataAccess.Manager
{
    public class UserManager
    {
        Md5 md = new Md5();
        //Barinak uye kaydı
        public Users RegisterCompany(Users user, string password)
        {
            using (var db = new DatabaseContext())
            {
                user.RoleId = 1;
                user.Password = md.getEnc(password);
             
                db.Users.Add(user);
                db.SaveChanges();
            }
            return user;
        }
        //Normal uye kaydı
        public Users RegisterUser(Users user, string password)
        {
            using (var db = new DatabaseContext())
            {
                user.RoleId = 2;
                user.Password = md.getEnc(password);

                db.Users.Add(user);
                db.SaveChanges();
            }
            return user;
        }
        //Kullanici mail adresi kullanılmış mı
        public Users UserControl(string mail)
        {
            using (var db = new DatabaseContext())
            {
                Users user = new Users();
                user = db.Users.FirstOrDefault(x => x.Mail == mail);
                return user;
            }
        }
        //Kullanici giris bilgileri dogru mu
        public Users UserInformationControl(string mail, string password)
        {
            using (var db = new DatabaseContext())
            {
                Users user = new Users();
                user = db.Users.FirstOrDefault(x => x.Mail == mail && x.Password == md.getEnc(password));
                return user;
            }
        }
        //Bilgileri dogrulanan useri dondurur
        public Users User(string mail, string password)
        {
            using (var db = new DatabaseContext())
            {
                Users user = new Users();
                user = db.Users.FirstOrDefault(x => x.Mail == mail && x.Password == md.getEnc(password));
                return user;
            }
        }
    }
}
