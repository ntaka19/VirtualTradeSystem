using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualTradeSystem.Data
{
    public class Market
    {
        //null許容型にする
        public double FxRate { get; set; }
        public double IrRate { get; set; }
        public double FxSigma { get; set; }
        public DateTime AsOf { get; set; }

        public double IrRateDom { get; set; }
        public double IrRateFor { get; set; }
        //public double FxMu { get; set; }
    }
}
