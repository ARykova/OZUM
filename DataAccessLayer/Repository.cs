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
        public List<Group> GetGroups()
        {
            List<Group> Groups = new List<Group>();
            Groups.Add(new Group
            {
                Login = "123",
                Password = "123",
                Name = "Миха",
                Telephone = "8812848248",
                Mail = "miha@milo.ru"
            });
            return Groups;
        }
        public List<Organizer> GetOrganizers()
        {
            List<Organizer> Organizers = new List<Organizer>();
            Organizers.Add(new Organizer
            {
                Login = "123621",
                Password = "123621",
                Name = "Анечка",
                Telephone = "88005553535",
                Mail = "anna@milo.ru"
            });
            return Organizers;
        }
    }
}
