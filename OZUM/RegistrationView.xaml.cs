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
using GalaSoft.MvvmLight.Messaging;

namespace OZUM
{
    /// <summary>
    /// Interaction logic for RegistrationView.xaml
    /// </summary>
    public partial class RegistrationView : ViewBase
    {
        public RegistrationView()
        {
            InitializeComponent();
            
            
        }


        private void textBoxLogin_KeyUp(object sender, KeyEventArgs e)
        {
            if (textBoxLogin.Text != "" && textBoxPassword.Text != "" && textBoxName.Text != ""
                && textBoxEmail.Text != "" && textBoxPhone.Text != "" &&
                (radioButtonGroup.IsChecked == true || radioButtonOrganizer.IsChecked == true))
            {
                buttonReg.IsEnabled = true;
            }
            else buttonReg.IsEnabled = false;
        }

        private void textBoxPassword_KeyUp(object sender, KeyEventArgs e)
        {
            if (textBoxLogin.Text != "" && textBoxPassword.Text != "" && textBoxName.Text != ""
                && textBoxEmail.Text != "" && textBoxPhone.Text != "" &&
                (radioButtonGroup.IsChecked == true || radioButtonOrganizer.IsChecked == true))
            {
                buttonReg.IsEnabled = true;
            }
            else buttonReg.IsEnabled = false;
        }

        private void radioButtonGroup_Checked(object sender, RoutedEventArgs e)
        {
            if (textBoxLogin.Text != "" && textBoxPassword.Text != "" && textBoxName.Text != ""
                && textBoxEmail.Text != "" && textBoxPhone.Text != "" &&
                (radioButtonGroup.IsChecked == true || radioButtonOrganizer.IsChecked == true))
            {
                buttonReg.IsEnabled = true;
            }
            else buttonReg.IsEnabled = false;
        }

        private void radioButtonOrganizer_Checked(object sender, RoutedEventArgs e)
        {
            if (textBoxLogin.Text != "" && textBoxPassword.Text != "" && textBoxName.Text != ""
                && textBoxEmail.Text != "" && textBoxPhone.Text != "" &&
                (radioButtonGroup.IsChecked == true || radioButtonOrganizer.IsChecked == true))
            {
                buttonReg.IsEnabled = true;
            }
            else buttonReg.IsEnabled = false;
        }

        private void textBoxName_KeyUp(object sender, KeyEventArgs e)
        {
            if (textBoxLogin.Text != "" && textBoxPassword.Text != "" && textBoxName.Text != ""
                && textBoxEmail.Text != "" && textBoxPhone.Text != "" &&
                (radioButtonGroup.IsChecked == true || radioButtonOrganizer.IsChecked == true))
            {
                buttonReg.IsEnabled = true;
            }
            else buttonReg.IsEnabled = false;
        }

        private void textBoxEmail_KeyUp(object sender, KeyEventArgs e)
        {
            if (textBoxLogin.Text != "" && textBoxPassword.Text != "" && textBoxName.Text != ""
                && textBoxEmail.Text != "" && textBoxPhone.Text != "" &&
                (radioButtonGroup.IsChecked == true || radioButtonOrganizer.IsChecked == true))
            {
                buttonReg.IsEnabled = true;
            }
            else buttonReg.IsEnabled = false;
        }

        private void textBoxPhone_KeyUp(object sender, KeyEventArgs e)
        {
            if (textBoxLogin.Text != "" && textBoxPassword.Text != "" && textBoxName.Text != ""
                && textBoxEmail.Text != "" && textBoxPhone.Text != "" &&
                (radioButtonGroup.IsChecked == true || radioButtonOrganizer.IsChecked == true))
            {
                buttonReg.IsEnabled = true;
            }
            else buttonReg.IsEnabled = false;
        }
    }
}
