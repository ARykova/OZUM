using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Group : IUser
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Information { get; set; }
        public string Telephone { get; set; }
        public string Mail { get; set; }
        public bool IsOrganizer { get; set; }

        public List<OrganizeEvent> AllEvents { get; set; }
        public List<OrganizeEvent> UpgoingEvents { get; set; }

    }
}
