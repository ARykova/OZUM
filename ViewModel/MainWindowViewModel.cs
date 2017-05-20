using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DataAccessLayer;

namespace ViewModel
{
    public class MainWindowViewModel: ViewModelBase
    {
        public List<Organizer> Organizers = new List<Organizer>();
        public List<Group> Groups = new List<Group>();

        public MainWindowViewModel()
        {
            var rep = new Repository();
            Groups = rep.GetGroups();
            Organizers = rep.GetOrganizers();
        }
    }
}
