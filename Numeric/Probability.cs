using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathNet.Numerics.Distributions;

namespace Numeric
{
    public static class Probability
    {
        const double mean = 0;
        const double std = 1.0;
        public static double CND(double x)
        {
            return Normal.CDF(mean, std, x);
        }

        public static double PDF(double x)
        {
            return Normal.PDF(mean, std, x);
        }
    }
}
