using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProMan_Simulator.Base
{
    public class BaseModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string name)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(name));
            }
        }

        public void ExecuteRequestClose()
        {
            if (RequestClose == null)
                throw new Exception("The \"RequestClose\" action was called but not wired. Check the stacktrace where it was called from.");
            else
                RequestClose();
        }

        public event Action RequestClose;
    }
}
