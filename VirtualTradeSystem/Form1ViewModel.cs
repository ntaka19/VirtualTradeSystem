using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VirtualTradeSystem.Core;
using VirtualTradeSystem.Data;

namespace VirtualTradeSystem
{
    public class Form1ViewModel : ViewModelBase
    {
        public BindingList<DealModel> Row { get; set; } = new BindingList<DealModel>();
        /*
        public BindingList<DealModel> Row
        {
            get { return row; }
            
            set { SetProperty(ref row, value); }
        }*/

        //public BindingList<DealModel> Row { get; set; } = new BindingList<DealModel>();

        public BindingList<DealModel> RowTemp { get; set; } = new BindingList<DealModel>();

        /*
        List<DealModel> row = new List<DealModel>();
        public List<DealModel> Row
        {
            get { return row; }
            set { SetProperty(ref row, value); }
        }*/

        /*
        List<DealModel> rowTemp = new List<DealModel>();
        public List<DealModel> RowTemp
        {

            get { return rowTemp; }
            set { SetProperty(ref rowTemp, value); }
        }*/
        
        public void SetDealAction()
        {
            RowTemp.Clear();
            //Clone しないと同じところで更新される。
            foreach (var item in Row)
            {
                RowTemp.Add((DealModel)item.Clone());
            }
        }



        //RowTempのPV計算を行う
        public void CalculatePVAction()
        {
            var market = new Market()
            {
                FxRate = 90,
                IrRateDom = 0.01,
                IrRateFor = 0.01,
                FxVolatility = 0.01
            };

            double test = 0;
            foreach(var deal in RowTemp)
            {
                test = BlackScholes.Pv(deal, market);
                deal.InitialPremium = BlackScholes.Pv(deal, market);
            }

            //RowTemp.Add(new DealModel { InitialPremium = test });


        }
    }
}
