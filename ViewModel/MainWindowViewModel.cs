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
            var rep = new Repository();
            Organizers = rep.GetOrganizers();
            Groups = rep.GetGroups();
        }


        private RelayCommand _registrationClick;
        public RelayCommand RegistrationClick
        {
            get { return _registrationClick ?? (_registrationClick = new RelayCommand(OnRegistrationClick)); }
        }
        private void OnRegistrationClick()
        {
            //List<IUser> allUsers = new List<IUser>();
            //foreach(Organizer org in Organizers)
            //{
            //    allUsers.Add(org);
            //}
            //foreach (Group group in Groups)
            //{
            //    allUsers.Add(group);
            //}

            RegistrationViewModel registrationViewModel = new RegistrationViewModel() { GroupReg = Groups, OrgReg = Organizers};
            ViewModelManager.Instance.ViewModelShow(registrationViewModel);
        }

        private RelayCommand _loginClick;
        public RelayCommand LoginClick
        {
            get { return _loginClick ?? (_loginClick = new RelayCommand(OnLoginClick)); }
        }
        private void OnLoginClick()
        {

            OrganizerViewModel orgViewModel = new OrganizerViewModel();
            ViewModelManager.Instance.ViewModelShow(orgViewModel);
        }
    }
}
