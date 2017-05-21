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
        public List<User> Users = new List<User>();
        

        public MainWindowViewModel()
        {            
            var rep = new Repository();
            Users = rep.GetUsers();
        }

        private void Instance_AddUser(User usr)
        {
            Users.Add(usr);
        }


        private RelayCommand _registrationClick;
        public RelayCommand RegistrationClick
        {
            get { return _registrationClick ?? (_registrationClick = new RelayCommand(OnRegistrationClick)); }
        }
        private void OnRegistrationClick()
        {
            
            RegistrationViewModel registrationViewModel = new RegistrationViewModel() { UsersReg = Users};
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
