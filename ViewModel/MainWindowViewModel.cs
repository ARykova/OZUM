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

            Organizers = rep.GetOrganizers();
            Groups = rep.GetGroups();
            List<OrganizeEvent> tmpEvents = rep.GetEvents();
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
                    GroupViewModel grViewModel = new GroupViewModel() { CurrentGroup = obj};
                    ViewModelManager.Instance.ViewModelShow(grViewModel);
                }
            }
            foreach (Organizer obj in Organizers)
            {
                if (obj.Login == LoginField)
                {
                    OrganizerViewModel orgViewModel = new OrganizerViewModel() { CurentOrg = obj};
                    ViewModelManager.Instance.ViewModelShow(orgViewModel);
                }
            }
        }
    }
}
