using System;

namespace VirtualTradeSystem
{
    public class Deal
    {
        //あとでenumにする。
        public string ID { get; set; }
        public EnumStatus Status { get; set; }
        public EnumDealType DealType { get; set; }
        public double Strike { get; set; }
        //public double Maturity { get;  set; }

        public bool IsBuy { get ; set; }

        private double lot; 
        public double Lot { 
            set { 
                if (value <=0)
                {
                    throw new ArgumentException("Need positive value");
                }
                this.lot = value ; 
            }
            get { return this.lot;  }
        }

        //public int DayCountBasis { get; set; }
        public double InitialPremium { get; set; }

        //FxRateSettked changed to strike
        public DateTime TradeDate { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }

        //public double Profit { get; set; }

    }

    public enum EnumStatus
    {
        Open, 
        Closed,
    }

    public enum EnumDealType
    {
        Call,
        Put,
        Spot,
    }

    //あとでここを変更する
    public enum EnumBuySell
    {
        Buy,
        Sell,
    }
}



