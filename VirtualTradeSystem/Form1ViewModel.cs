using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VirtualTradeSystem
{
    public class Form1ViewModel : ViewModelBase
    {
        
        BindingList<Deal> row = new BindingList<Deal>();
        public BindingList<Deal> Row
        {

            get { return row; }
            //set { }
            set { SetProperty(ref row, value); }
        }


        BindingList<Deal> rowTemp = new BindingList<Deal>();
        public BindingList<Deal> RowTemp
        {

            get { return rowTemp; }
            //set { }
            set { SetProperty(ref rowTemp, value); }
        }

        public void SetDealAction()
        {
            RowTemp.Clear();
            foreach (var item in Row)
            {
                RowTemp.Add(item);
            }
        }

        //RowTempのPV計算を行う
        public void CalculatePVAction()
        {

        }
    }
}
