using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Schedule
    {
        public int Id { get; set; }

        public virtual OrganizeEvent OE { get; set; }
        public Group Member { get; set; }
        public DateTime Duration { get; set; }
    }
}
