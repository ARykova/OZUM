using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DataAccessLayer;
using GalaSoft.MvvmLight.Command;

namespace ViewModel
{
    public class MainWindowViewModel: ViewModelBase
    {
        public List<Organizer> Organizers = new List<Organizer>();
        public List<Group> Groups = new List<Group>();

        public MainWindowViewModel()
        {            
            var rep = new SQLRepository();

            //var group1 = new Group { Login = "1", Password = "1", Mail = " 123", Telephone = "12345", Name = "Dada", IsOrganizer = false };
            //var org1 = new Organizer { Name = "Fedor", IsOrganizer = true, Telephone = "123", Mail = "123", Password = "123", Login = "123"};

            //var event1 = new OrganizeEvent { Name = "event1", Start = DateTime.Parse("12.02.2017"), Finish = DateTime.Parse("12.04.2017"), EventsOrganizer = org1 };
            //var event2 = new OrganizeEvent { Name = "event2", Start = DateTime.Parse("12.02.2017"), Finish = DateTime.Parse("12.04.2017"), EventsOrganizer = org1 };

            //rep.AddGroup(group1);
            //rep.AddOrganizer(org1);
            //rep.AddOrganizeEvent(event1);
            //rep.AddOrganizeEvent(event2);
            //rep.Save();

            Organizers = rep.GetOrganizers();
            Groups = rep.GetGroups();

            foreach (Organizer o in Organizers)
            {
                foreach(OrganizeEvent oe in rep.GetEvents())
                {
                    if (oe.EventsOrganizer.Id == o.Id) o.AllIvents.Add(oe);
                }
            }

            //foreach (Group g in Groups)
            //{
            //    foreach (OrganizeEvent oe in rep.GetEvents())
            //    {
            //        if (oe.Schedule.Member.Id == g.Id) g.AllEvents.Add(oe);
            //    }
            //}
        }


        private RelayCommand _registrationClick;
        public RelayCommand RegistrationClick
        {
            get { return _registrationClick ?? (_registrationClick = new RelayCommand(OnRegistrationClick)); }
        }
        private void OnRegistrationClick()
        {
            RegistrationViewModel registrationViewModel = new RegistrationViewModel() { GroupReg = Groups, OrgReg = Organizers};
            ViewModelManager.Instance.ViewModelShow(registrationViewModel);
        }

        public string LoginField { get; set; }

        private RelayCommand _loginClick;
        public RelayCommand LoginClick
        {
            get { return _loginClick ?? (_loginClick = new RelayCommand(OnLoginClick)); }
        }
        private void OnLoginClick()
        {
            foreach (Group obj in Groups)
            {
                if (obj.Login == LoginField)
                {
                    GroupViewModel grViewModel = new GroupViewModel();
                    ViewModelManager.Instance.ViewModelShow(grViewModel);
                }
            }
            foreach (Organizer obj in Organizers)
            {
                if (obj.Login == LoginField)
                {
                    OrganizerViewModel orgViewModel = new OrganizerViewModel() { CurentOrg = obj, CurentOrgEvents = obj.AllIvents };
                    ViewModelManager.Instance.ViewModelShow(orgViewModel);
                }
            }
        }
    }
}
