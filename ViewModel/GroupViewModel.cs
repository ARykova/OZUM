using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
    public class GroupViewModel : ViewModelBase
    {
        private RelayCommand _fillAppClick;
        public RelayCommand FillAppClick
        {
            get { return _fillAppClick ?? (_fillAppClick = new RelayCommand(OnFillAppClick)); }
        }
        private void OnFillAppClick()
        {
            FillApplicationViewModel fillAppViewModel = new FillApplicationViewModel();
            ViewModelManager.Instance.ViewModelShow(fillAppViewModel);
        }

        private RelayCommand _showEventDetailsClick;
        public RelayCommand ShowEventDetailsClick
        {
            get { return _showEventDetailsClick ?? (_showEventDetailsClick = new RelayCommand(OnShowEventDetailsClick)); }
        }
        private void OnShowEventDetailsClick()
        {
            ShowEventDetailsViewModel sedViewModel = new ShowEventDetailsViewModel();
            ViewModelManager.Instance.ViewModelShow(sedViewModel);
        }

        private RelayCommand _logOutClick;
        public RelayCommand LogOutClick
        {
            get { return _logOutClick ?? (_logOutClick = new RelayCommand(OnLogOutClick)); }
        }
        private void OnLogOutClick()
        {
            //доп логика выхода из аккаунта ???
            Close();
        }
    }
}
