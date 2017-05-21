using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace DataAccessLayer
{
    public class Repository
    {
        public List<User> GetUsers()
        {
            List<User> Users = new List<User>();
            Users.Add(new User
            {
                Login = "123621",
                Password = "123621",
                Name = "Анечка",
                Telephone = "8812848248",
                Mail = "anna@milo.ru"
            });
            Users.Add(new User
            {
                Login = "123",
                Password = "123",
                Name = "Миха",
                Telephone = "88005553535",
                Mail = "miha@milo.ru"
            });
            return Users;
        }
        
    }
}
