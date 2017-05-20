using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
    public class ViewModelBase
    {

        public event EventHandler Closed;

        public bool IsClosed { get; set; }

        public bool IsNew { get; set; }

        protected virtual bool OnClosing()
        {
            return true;//BL validator
        }

        public void Close()
        {
            if (!IsClosed && OnClosing())
            {
                IsClosed = true;
                OnClosed();
            }
        }

        private void OnClosed()
        {
            ViewModelManager.Instance.ViewModelClose(this);
            EventHandler handler = Closed;
            if (handler != null) handler(this, EventArgs.Empty);
        }
        public override bool Equals(object o)
        {
            return this.GetType() == o.GetType();
        }
        public override int GetHashCode()
        {
            return this.GetType().GetHashCode();
        }
    }
}

