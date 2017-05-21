using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using ViewModel;

namespace OZUM
{
    public class ViewManager
    {
        public static void ViewShow(ViewModelBase viewModel)
        {
            foreach (ViewModelBase vmb in OpenViewModelMapping.Keys)
            {
                if (viewModel.Equals(vmb))
                {
                    throw new ArgumentException("View model is open");
                }
            }
            var typeViewModel = viewModel.GetType();
            if (Mapping.ContainsKey(typeViewModel))
            {
                Type typeView = Mapping[typeViewModel];
                var window = (Window)Activator.CreateInstance(typeView);

                window.DataContext = viewModel;
                window.Show();

                OpenViewModelMapping.Add(viewModel, window);
            }
        }


        public static void ViewClose(ViewModelBase viewModel)
        {
            if (OpenViewModelMapping.ContainsKey(viewModel))
            {
                var window = OpenViewModelMapping[viewModel];
                window.Close();

                OpenViewModelMapping.Remove(viewModel);
            }
        }
        private static readonly Dictionary<Type, Type> Mapping =
            new Dictionary<Type, Type>
                {
                    {typeof(RegistrationViewModel), typeof(RegistrationView)},
                    {typeof(MainWindowViewModel), typeof(MainWindow)},
                };

        private static readonly Dictionary<ViewModelBase, Window> OpenViewModelMapping
            = new Dictionary<ViewModelBase, Window>();
    }
}
