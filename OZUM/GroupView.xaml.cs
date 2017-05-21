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
using ViewModel;

namespace OZUM
{
    /// <summary>
    /// Interaction logic for GroupView.xaml
    /// </summary>
    public partial class GroupView : ViewBase
    {
        public GroupView()
        {
            InitializeComponent();
        }

        private void buttonFillApplication_Click(object sender, RoutedEventArgs e)
        {
            var faWindow = new FillApplicationView();
            faWindow.Show();
        }
    }
}
