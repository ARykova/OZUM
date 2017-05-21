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
    /// Interaction logic for NewEventView.xaml
    /// </summary>
    public partial class NewEventView : ViewBase
    {
        public NewEventView()
        {
            InitializeComponent();
        }

        private void textBoxEventName_KeyUp(object sender, KeyEventArgs e)
        {
            if (textBoxEventName.Text != "" && datePickerEnd.SelectedDate >= datePickerStart.SelectedDate &&
                datePickerStart.SelectedDate >= DateTime.Now)
            {
                buttonAddEvent.IsEnabled = true;
            }
            else
            {
                buttonAddEvent.IsEnabled = false;
            }
        }

        private void datePickerStart_MouseDown(object sender, MouseButtonEventArgs e)
        {
            
        }

        private void datePickerEnd_MouseDown(object sender, MouseButtonEventArgs e)
        {
            
        }

        private void datePickerStart_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            if (textBoxEventName.Text != "" && datePickerEnd.SelectedDate >= datePickerStart.SelectedDate &&
                datePickerStart.SelectedDate >= DateTime.Now)
            {
                buttonAddEvent.IsEnabled = true;
            }
            else
            {
                buttonAddEvent.IsEnabled = false;
            }
        }

        private void datePickerEnd_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            if (textBoxEventName.Text != "" && datePickerEnd.SelectedDate >= datePickerStart.SelectedDate &&
               datePickerStart.SelectedDate >= DateTime.Now)
            {
                buttonAddEvent.IsEnabled = true;
            }
            else
            {
                buttonAddEvent.IsEnabled = false;
            }
        }
    }
}
