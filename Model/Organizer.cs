using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Organizer
    {
        public Organizer(string login, string password, string name, string mail, int telephone, string inforamtion)
        {
            Login = login;
            Password = password;
            Name = name;
            Mail = mail;
            Telephone = telephone;
            Information = inforamtion;
        }

        public string Login;
        public string Password;

        public string Name;
        public string Information;
        public int Telephone;
        public string Mail;

        List<OrganizeEvent> LastEvents;
        List<OrganizeEvent> UpcommingEvents;
    }
}
