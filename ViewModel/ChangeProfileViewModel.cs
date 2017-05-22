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
    public class ChangeProfileViewModel : ViewModelBase
    {
        public Organizer OrgChangingSettings = new Organizer();
        public Group GrpChangingSettings = new Group();
        public bool IsThisOrg { get; set; }
        public ChangeProfileViewModel()
        {
            
        }

        public string Password { get; set; }
        public string Name { get; set; }
        public string Information { get; set; }
        public string Phone { get; set; }
        public string Mail { get; set; }



        private RelayCommand _saveClick;
        public RelayCommand SaveClick
        {
            get { return _saveClick ?? (_saveClick = new RelayCommand(OnSaveClick)); }
        }
        private void OnSaveClick()
        {
            if(IsThisOrg)
            {
                OrgChangingSettings.Password = Password;
                OrgChangingSettings.Name = Name;
                OrgChangingSettings.Telephone = Phone;
                OrgChangingSettings.Mail = Mail;
                OrgChangingSettings.Information = Information;
                var rep = new SQLRepository();
                rep.ChangeOrganizerInformation(OrgChangingSettings);
                rep.Save();
            }
            else
            {
                GrpChangingSettings.Password = Password;
                GrpChangingSettings.Name = Name;
                GrpChangingSettings.Telephone = Phone;
                GrpChangingSettings.Mail = Mail;
                GrpChangingSettings.Information = Information;
                var rep = new SQLRepository();
                rep.ChangeGroupInformation(GrpChangingSettings);
                rep.Save();
            }
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
