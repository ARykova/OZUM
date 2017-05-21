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
    /// Interaction logic for FillApplicationView.xaml
    /// </summary>
    public partial class FillApplicationView : ViewBase
    {
        public FillApplicationView()
        {
            InitializeComponent();
        }

        private void comboBoxEvent_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            buttonSendApplication.IsEnabled = comboBoxEvent.Text != "" && textBoxDuration.Text != "";
        }

        private void textBoxDuration_KeyUp(object sender, KeyEventArgs e)
        {
            buttonSendApplication.IsEnabled = comboBoxEvent.Text != "" && textBoxDuration.Text != "";
        }

        private void buttonCancelFillApplication_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
