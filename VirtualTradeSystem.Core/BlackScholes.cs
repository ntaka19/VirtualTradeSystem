using Numeric;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VirtualTradeSystem.Data;

namespace VirtualTradeSystem.Core
{
    public static class BlackScholes
    {
        private static double eps = 0.00001;
        /*
        public static double Pv(Deal deal, Market market)
        {
            double t = (deal.Maturity.Value - market.AsOf).TotalDays;
            double d1 = (Math.Log((market.FxRate) / (double)deal.Strike) + (market.IrRate + Math.Pow(market.FxSigma, 2) / 2) * (t)) / (market.FxSigma * Math.Sqrt(t+eps));
            double d2 = d1 - market.FxSigma * Math.Sqrt(t);
            double sign = deal.DealType == EnumDealType.Call ? 1.0 : -1.0;
            return sign * (market.FxRate * Probability.CND(sign * d1) - (double)deal.Strike * Math.Exp(-market.IrRate * (t)) * Probability.CND(sign * d2));
        }*/


        public static double Pv(Deal deal, Market market)
        {
            //Discount to current priceMU       sdfs                
            double dcf = 1.0; // Math.Pow(1 / (1 + market.IrRateDom/100/MarketSetting.AnnualDays), (deal.StartDate - market.AsOf).Days); 
            double t = (deal.EndDate.Value - market.AsOf).TotalDays;
            double d1 = (Math.Log((market.FxRate) / (double)deal.Strike) + (market.IrRateDom / MarketSetting.AnnualDays - market.IrRateFor / MarketSetting.AnnualDays + Math.Pow(market.FxVolatility, 2) / 2) * (t)) / (market.FxVolatility * Math.Sqrt(t + eps));
            double d2 = d1 - market.FxVolatility * Math.Sqrt(t);
            double sign = deal.DealType == EDealType.Call ? 1.0 : -1.0;
            return deal.Lot * sign * dcf * (market.FxRate * Math.Exp(-market.IrRateFor / (MarketSetting.AnnualDays) * t) * Probability.CND(sign * d1) - (double)deal.Strike * Math.Exp(-market.IrRateDom / MarketSetting.AnnualDays * (t)) * Probability.CND(sign * d2));

        }
    }
}
