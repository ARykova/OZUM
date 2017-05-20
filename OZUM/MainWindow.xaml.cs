using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace OZUM
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var regWindow = new RegistrationView();
            regWindow.Show();
        }

        private void buttonLogIn_Click(object sender, RoutedEventArgs e)
        {
            int i = 0;

            if (i == 5)
            {
                var grWindow = new GroupView();
                grWindow.Show();
            }

            else
            {
                var orgWindow = new OrganizerView();
                orgWindow.Show();
            }
        }
    }
}
