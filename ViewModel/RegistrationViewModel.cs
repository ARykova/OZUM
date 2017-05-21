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
        //public IUser RVMU { get; set; }
        public List<Group> GroupReg = new List<Group>();
        public List<Organizer> OrgReg = new List<Organizer>();

        public string RegLogin { get; set; }
        public string RegPassword { get; set; }
        public string RegName { get; set; }
        public string RegInformation { get; set; }
        public string RegTelephone { get; set; }
        public string RegMail { get; set; }
        public bool IsOrganizer { get; set; }

        public RegistrationViewModel()
        {
            //RVMU = new IUser();
            
            

        }

        private RelayCommand _saveClick;
        public RelayCommand SaveClick
        {
            get { return _saveClick ?? (_saveClick = new RelayCommand(OnSaveClick)); }
        }
        private void OnSaveClick()
        {
            foreach (Organizer user in OrgReg)
            {
                if (user.Login == RegLogin)
                {
                    throw new Exception("Такой Логин уже используется");

                }
            }
            foreach (Group user in GroupReg)
            {
                if (user.Login == RegLogin)
                {
                    throw new Exception("Такой Логин уже используется");

                }
            }

            if(IsOrganizer)
            {
                OrgReg.Add(new Organizer
                {
                    Login = RegLogin,
                    Password = RegPassword,
                    Name = RegName,
                    Telephone = RegTelephone,
                    Mail = RegMail,
                    Information = RegInformation,
                    //IsOrganizer = true
                    
                });
            }
            else
            {
                GroupReg.Add(new Group
                {
                    Login = RegLogin,
                    Password = RegPassword,
                    Name = RegName,
                    Telephone = RegTelephone,
                    Mail = RegMail,
                    Information = RegInformation,
                    //IsOrganizer = false

                });
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
