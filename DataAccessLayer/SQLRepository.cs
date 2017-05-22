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

        public List<SchedulePart> GetScheduleParts()
        {
            return _context.ScheduleParts.ToList();
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
            _context.ScheduleParts.Add(s);
        }

        public void ChangeSchedule(SchedulePart s, bool check)
        {
            if (check) _context.ScheduleParts.Find(s.Id).IsChecked = check;
            else
            {
                _context.ScheduleParts.Remove(_context.ScheduleParts.Find(s.Id));
            }
        }

        public void ChangeGroupInformation(Group g)
        {
            _context.Groups.Find(g.Id).Password = g.Password;
            _context.Groups.Find(g.Id).Name = g.Name;
            _context.Groups.Find(g.Id).Information = g.Information;
            _context.Groups.Find(g.Id).Telephone = g.Telephone;
            _context.Groups.Find(g.Id).Mail = g.Mail;
            
        }

        public void ChangeOrganizerInformation(Organizer o)
        {
            _context.Organizers.Find(o.Id).Password = o.Password;
            _context.Organizers.Find(o.Id).Name = o.Name;
            _context.Organizers.Find(o.Id).Information = o.Information;
            _context.Organizers.Find(o.Id).Telephone = o.Telephone;
            _context.Organizers.Find(o.Id).Mail = o.Mail;

        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
