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
using System.Windows.Shapes;

namespace OZUM
{
    /// <summary>
    /// Interaction logic for OrganizerView.xaml
    /// </summary>
    public partial class OrganizerView : Window
    {
        public OrganizerView()
        {
            InitializeComponent();
        }

        private void buttonNewEvent_Click(object sender, RoutedEventArgs e)
        {
            var neWindow = new NewEventView();
            neWindow.Show();
        }

        private void buttonChangeSchedule_Click(object sender, RoutedEventArgs e)
        {
            var csWindow = new ChangeScheduleView();
            csWindow.Show();
        }
    }
}
