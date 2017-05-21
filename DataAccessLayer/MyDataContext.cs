using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;


namespace DataAccessLayer
{
    class MyDataContext : DbContext
    {
        public DbSet<Group> Groups { get; set; }
        public DbSet<Organizer> Organizers { get; set; }
        //public DbSet<Apply> Applies { get; set; }
        public DbSet<OrganizeEvent> OrganizeEvents { get; set; }
        public DbSet<SchedulePart> Schedules { get; set; }
    }
}
