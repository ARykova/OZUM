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
    /// Interaction logic for ChangeProfileView.xaml
    /// </summary>
    public partial class ChangeProfileView : ViewBase
    {
        public ChangeProfileView()
        {
            InitializeComponent();
        }

        private void textBoxPassword_KeyDown(object sender, KeyEventArgs e)
        {
            buttonSaveProfileChanges.IsEnabled = textBoxPassword.Text != "" && textBoxName.Text != "" && textBoxPhone.Text != ""
                && textBoxEmail.Text != "";
        }

        private void textBoxName_KeyUp(object sender, KeyEventArgs e)
        {
            buttonSaveProfileChanges.IsEnabled = textBoxPassword.Text != "" && textBoxName.Text != "" && textBoxPhone.Text != ""
                && textBoxEmail.Text != "";
        }

        private void textBoxInfo_KeyUp(object sender, KeyEventArgs e)
        {
            buttonSaveProfileChanges.IsEnabled = textBoxPassword.Text != "" && textBoxName.Text != "" && textBoxPhone.Text != ""
                && textBoxEmail.Text != "";
        }

        private void textBoxPhone_KeyUp(object sender, KeyEventArgs e)
        {
            buttonSaveProfileChanges.IsEnabled = textBoxPassword.Text != "" && textBoxName.Text != "" && textBoxPhone.Text != ""
                && textBoxEmail.Text != "";
        }

        private void textBoxEmail_KeyDown(object sender, KeyEventArgs e)
        {
            buttonSaveProfileChanges.IsEnabled = textBoxPassword.Text != "" && textBoxName.Text != "" && textBoxPhone.Text != ""
                && textBoxEmail.Text != "";
        }
    }
}
