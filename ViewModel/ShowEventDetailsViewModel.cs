using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
    public class ShowEventDetailsViewModel : ViewModelBase
    {
        private RelayCommand _okClick;
        public RelayCommand OkClick
        {
            get { return _okClick ?? (_okClick = new RelayCommand(OnOkClick)); }
        }
        private void OnOkClick()
        {
            Close();
        }
    }
}
