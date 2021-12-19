using HrrMrr.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace HrrMrr.DataAccess.Manager
{
    public class UserManager
    {
        public Users Register(Users user, string password)
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
    }
}
