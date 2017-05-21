using System.Collections.Generic;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using GalaSoft.MvvmLight.Command;

namespace ViewModel
{
    public class RegistrationViewModel : ViewModelBase
    {
        public User RVMU { get; set; }
        public List<User> UsersReg { get; set; }
        public RegistrationViewModel()
        {
            RVMU = new User();            
        }

        private RelayCommand _saveClick;
        public RelayCommand SaveClick
        {
            get { return _saveClick ?? (_saveClick = new RelayCommand(OnSaveClick)); }
        }
        private void OnSaveClick()
        {
            UsersReg.Add(RVMU);
            Close();
        }
    }
}
