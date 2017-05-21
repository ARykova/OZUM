using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace ViewModel
{
    public class GroupViewModel : ViewModelBase
    {
        public Group CurrentGroup { get; set; }
        public List<SchedulePart> Accepted { get; set; }
        public List<SchedulePart> NotAccepted { get; set; }
        public SchedulePart Chosen { get; set; }

        public GroupViewModel()
        {

        }




        //Кнопки
        

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
            ShowEventDetailsViewModel sedViewModel = new ShowEventDetailsViewModel() { Eventyshe = Chosen.OE};
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
