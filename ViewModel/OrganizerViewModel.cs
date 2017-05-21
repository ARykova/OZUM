using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DataAccessLayer;

namespace ViewModel
{
    public class OrganizerViewModel : ViewModelBase
    {
        public Organizer CurentOrg { get; set; }
        public List<Group> GroupsOrg { get; set; }
        //List<SchedulePart> CurentApplies { get; set; }

        public OrganizerViewModel()
        {

        }


        List<SchedulePart> CurentApplies
        { get
            {
                foreach (Group gr in GroupsOrg)
                {
                    foreach (SchedulePart sp in gr.Applies)
                    {
                        if (!sp.IsChecked && sp.OE.EventsOrganizer == CurentOrg) CurentApplies.Add(sp);
                    }
                }
                return CurentApplies;
            }
        }       

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

        private RelayCommand _changeProfileClick;
        public RelayCommand ChangeProfileClick
        {
            get { return _changeProfileClick ?? (_changeProfileClick = new RelayCommand(OnChangeProfileClick)); }
        }
        private void OnChangeProfileClick()
        {
            ChangeProfileViewModel cpViewModel = new ChangeProfileViewModel();
            ViewModelManager.Instance.ViewModelShow(cpViewModel);
        }
    }
}
