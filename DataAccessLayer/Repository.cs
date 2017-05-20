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
        public List<Organizer> GetOrganizers()
        {
            List<Organizer> Organizers = new List<Organizer>();
            Organizers.Add(new Organizer
            {
                Login = "123",
                Password = "123",
                Name = "Миха",
                Telephone = "88005553535",
                Mail = "miha@milo.ru"
            });
            return Organizers;
        }

        public List<Organizer> GetGroups()
        {
            List<Organizer> Groups = new List<Organizer>();
            Groups.Add(new Organizer
            {
                Login = "123621",
                Password = "123621",
                Name = "Анечка",
                Telephone = "88005553535",
                Mail = "anna@milo.ru"
            });
            return Groups;
        }
    }
}
