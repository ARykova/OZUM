using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class OrganizeEvent
    {
        public string Name;
        public Organizer EventsOrganizer;
        public string Information;
        List<SchedulePart> Schedule;

        public DateTime Start;
        public DateTime Finish;

        List<Group> OnRegistration;
    }
}
