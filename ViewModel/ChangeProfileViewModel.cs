using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace ViewModel
{
    public class ChangeProfileViewModel : ViewModelBase
    {
        public IUser ChangingSettings { get; set; }


        private RelayCommand _saveClick;
        public RelayCommand SaveClick
        {
            get { return _saveClick ?? (_saveClick = new RelayCommand(OnSaveClick)); }
        }
        private void OnSaveClick()
        {
            
            Close();
        }


        private RelayCommand _cancelClick;
        public RelayCommand CancelClick
        {
            get { return _cancelClick ?? (_cancelClick = new RelayCommand(OnCancelClick)); }
        }
        private void OnCancelClick()
        {
            Close();
        }
    }
}
