﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using ViewModel;

namespace OZUM
{
    public class ViewBase: Window
    {
        protected override void OnClosing(System.ComponentModel.CancelEventArgs e)
        {
            base.OnClosing(e);
            if (!((ViewModelBase)DataContext).IsClosed)
            {
                e.Cancel = true;
                Dispatcher.BeginInvoke(new Action(() => ((ViewModelBase)DataContext).Close()));
                //((ViewModelBase)DataContext).Close();
            }
        }
    }
}
