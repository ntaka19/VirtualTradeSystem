using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace VirtualTradeSystem
{
    public class DealModel : Deal, INotifyPropertyChanged, ICloneable
    {
        double premium = 0;
        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public double InitialPremium
        {
            get { return premium; }
            //set { SetProperty(ref premium, value); }

            set
            {
                if (value != this.premium)
                {
                    this.premium = value;
                    NotifyPropertyChanged();
                }
            }
        }
        public Object Clone()
        {
            return (DealModel)this.MemberwiseClone();
        }

        /*
        public event PropertyChangedEventHandler PropertyChanged;
        protected bool SetProperty<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (Equals(field, value))
            {
                return false;
            }

            field = value;
            var h = this.PropertyChanged;
            if (h != null)
            {
                h(this, new PropertyChangedEventArgs(propertyName));
            }

            return true;
        }*/
    }
      
}



