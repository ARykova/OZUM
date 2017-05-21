using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
    public class OrganizerViewModel : ViewModelBase
    {
        private RelayCommand _newEventClick;
        public RelayCommand NewEventClick
        {
            get { return _newEventClick ?? (_newEventClick = new RelayCommand(OnNewEventClick)); }
        }
        private void OnNewEventClick()
        {
            NewEventViewModel neViewModel = new NewEventViewModel();
            ViewModelManager.Instance.ViewModelShow(neViewModel);
        }

        private RelayCommand _changeScheduleClick;
        public RelayCommand ChangeScheduleClick
        {
            get { return _changeScheduleClick ?? (_changeScheduleClick = new RelayCommand(OnChangeScheduleClick)); }
        }
        private void OnChangeScheduleClick()
        {
            ChangeScheduleViewModel csViewModel = new ChangeScheduleViewModel();
            ViewModelManager.Instance.ViewModelShow(csViewModel);
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
