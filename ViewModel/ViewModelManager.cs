using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
    public class ViewModelManager
    {
        //приватим для сингтона
        private ViewModelManager()
        {

        }

        //синглтон
        private static ViewModelManager _instance;
        public static ViewModelManager Instance
        {
            get
            {
                return _instance
                ?? (_instance = new ViewModelManager());
            }
        }
        //создаём делегат и передаём в него окно
        public delegate void ViewModelShowDelegate(ViewModelBase viewModel);

        //создаём ивент открытия окна (подписываемся на него в App.xaml.cs)
        public event ViewModelShowDelegate ViewModelShowEvent;

        //функция, вызывающая приватную функцию
        public void ViewModelShow(ViewModelBase viewModel)
        {
            OnViewModelShowEvent(viewModel);
        }
        //пинаем ивент на открытие
        private void OnViewModelShowEvent(ViewModelBase viewmodel)
        {
            ViewModelShowDelegate handler = ViewModelShowEvent;
            if (handler != null) handler(viewmodel);
        }

        //всё тоже самое, только с закрытием
        public delegate void ViewModelCloseDelegate(ViewModelBase viewModel);

        public event ViewModelCloseDelegate ViewModelCloseEvent;

        public void ViewModelClose(ViewModelBase viewModel)
        {
            OnViewModelCloseEvent(viewModel);
        }

        private void OnViewModelCloseEvent(ViewModelBase viewmodel)
        {
            ViewModelCloseDelegate handler = ViewModelCloseEvent;
            if (handler != null) handler(viewmodel);
        }

    }
}
