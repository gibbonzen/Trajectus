using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Trajectus.Models;

namespace Trajectus.Services
{
    public class UserServices
    {
        public void SeedUser()
        {
            using (var db = new Db())
            {
                User user = new User();
                user.Login = "titi";
                user.Password = "titi";

                db.Users.Add(user);
                db.SaveChanges();
            }
        }
    }
}