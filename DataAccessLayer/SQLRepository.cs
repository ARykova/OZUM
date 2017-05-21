using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Data.SqlClient;
using System.Data.Entity;

namespace DataAccessLayer
{
    public class SQLRepository : IRepository
    {
        private MyDataContext _context = new MyDataContext();

        public List<Group> GetGroups()
        {
            return _context.Groups.ToList();
        }
        public List<Organizer> GetOrganizers()
        {
            return _context.Organizers.ToList();
        }
        
        //public List<Apply> GetApplies()
        //{
        //    return _context.Applies.ToList();
        //}

        public List<OrganizeEvent> GetEvents()
        {
            return _context.OrganizeEvents.ToList();
        }

        //public void AddApply(Apply a)
        //{
        //    _context.Applies.Add(a);
        //}

        public void AddGroup(Group g)
        {
            _context.Groups.Add(g);
        }

        public void AddOrganizeEvent(OrganizeEvent oe)
        {
            _context.OrganizeEvents.Add(oe);
        }

        public void AddOrganizer(Organizer o)
        {
            _context.Organizers.Add(o);
        }

        public void AddSchedule(SchedulePart s)
        {
            _context.Schedules.Add(s);
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
