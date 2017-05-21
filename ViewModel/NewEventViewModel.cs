using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using Model;

namespace ViewModel
{
    public class NewEventViewModel : ViewModelBase
    {
        public string NewName { get; set; }
        public DateTime NewStart { get; set; }
        public DateTime NewEnd { get; set; }
        public string NewInformation { get; set; }
        public Organizer CurentOrg { get; set; }

        private RelayCommand _cancelClick;
        public RelayCommand CancelClick
        {
            get { return _cancelClick ?? (_cancelClick = new RelayCommand(OnCancelClick)); }
        }
        private void OnCancelClick()
        {
            Close();
        }

        private RelayCommand _saveNewEventClick;
        public RelayCommand SaveNewEventClick
        {
            get { return _saveNewEventClick ?? (_saveNewEventClick = new RelayCommand(OnSaveNewEventClick)); }
        }
        private void OnSaveNewEventClick()
        {
            var rep = new SQLRepository();
            OrganizeEvent NewOrgEvent = new OrganizeEvent()
            {
                Name = NewName,
                Start = NewStart,
                Finish = NewEnd,
                Information = NewInformation,
                EventsOrganizer = CurentOrg
            };
            rep.AddOrganizeEvent(NewOrgEvent);            
            rep.Save();
        }
    }
}
