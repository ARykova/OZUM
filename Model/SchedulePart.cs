using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class SchedulePart
    {
        public int Id { get; set; }

        public virtual OrganizeEvent OE { get; set; }
        public Group Member { get; set; }
        public TimeSpan Duration { get; set; }
        public bool IsChecked { get; set; }
    }
}
