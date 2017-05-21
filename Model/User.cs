using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class User: ICloneable
    {
        public int Id { get; set; }

        public string Login { get; set; }
        public string Password { get; set; }

        public string Name { get; set; }
        public string Information { get; set; }
        public string Telephone { get; set; }
        public string Mail { get; set; }

        public bool IsOrganizer { get; set; }

        public List<OrganizeEvent> AllEvents;

        private List<OrganizeEvent> _outgoingApplications;
        public List<OrganizeEvent> OutgoingApplications
        {
            get
            {
                if (!IsOrganizer) return _outgoingApplications;
                else return null;
            }
            set
            {
                if (!IsOrganizer) _outgoingApplications = value;
                else _outgoingApplications = null;
            }
        }

        object ICloneable.Clone()
        {
            return Clone();
        }

        public User Clone()
        {
            return new User
            {
                Name = Convert.ToString(Name),
                Login = Convert.ToString(Login),
                Password = Convert.ToString(Password),
                Information = Convert.ToString(Information),
                Telephone = Convert.ToString(Telephone),
                Mail = Convert.ToString(Mail),
               // IsOrganizer = IsOrganizer
            };
        }
    }
}
