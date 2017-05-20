using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Organizer: ILoginable
    {
        public string Login { get; set; }
        public string Password { get; set; }

        public string Name { get; set; }
        public string Information { get; set; }
        public string Telephone { get; set; }
        public string Mail { get; set; }

        List<OrganizeEvent> AllEvents;
    }
}
