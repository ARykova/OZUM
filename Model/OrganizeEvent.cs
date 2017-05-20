using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class OrganizeEvent
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public Organizer EventsOrganizer { get; set; }
        public string Information { get; set; }
        Schedule Schedule { get; set; }

        public DateTime Start { get; set; }
        public DateTime Finish { get; set; }

        List<Group> OnRegistration;
    }
}
