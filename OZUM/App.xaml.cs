using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using ViewModel;

namespace OZUM
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            //подписка на ивенты ниженаписанных функций(ниже там)
            ViewModelManager.Instance.ViewModelShowEvent
                += Instance_ViewModelShowEvent;
            ViewModelManager.Instance.ViewModelCloseEvent
                += Instance_ViewModelCloseEvent;

            var mainWindowViewModel = new MainWindowViewModel();
            ViewModelManager.Instance.ViewModelShow(mainWindowViewModel);
        }

        //вот этой
        private void Instance_ViewModelShowEvent(ViewModelBase viewmodel)
        {
            Dispatcher.BeginInvoke(new Action(() => ViewManager.ViewShow(viewmodel)));
        }

        //и вот этой
        private void Instance_ViewModelCloseEvent(ViewModelBase viewmodel)
        {
            Dispatcher.BeginInvoke(new Action(() => ViewManager.ViewClose(viewmodel)));
        }
    }
}
