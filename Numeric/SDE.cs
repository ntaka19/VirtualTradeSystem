using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathNet.Numerics.Distributions;
using MathNet.Numerics.Random;
using VirtualTradeSystem.Data;

namespace Numeric
{
    public static class SDE
    {
        //特定の確率微分方程式を数値計算手法を受け取り計算する。
        public static IList<double[]> GeoBrownian(int seedStart, double initialValue, DateTime initialDate, DateTime finalDate, int numPoints, int numPath, Market market, ISdeMethod sdeMethod)
        {

            double mu = 0;
            double dt = (finalDate - initialDate).TotalDays / numPoints;
            var xArrList = new List<double[]>();
            double A, B;
            int seed = seedStart * numPath;

            //LINQで書く方法を考える。
            for (int j = 0; j < numPath; j++)
            {
                var dwList = Wiener(seed + j, initialDate, finalDate, numPoints);
                var xArr = new double[numPoints];
                xArr[0] = initialValue;

                for (int i = 1; i < numPoints; i++)
                {
                    //GeoBrownian 特有の計算A, B 
                    A = xArr[i - 1] * mu;
                    B = xArr[i - 1] * (double)market.FxSigma;
                    xArr[i] = sdeMethod.NextStep(xArr[i - 1], A, B, dwList[i], dt);
                }
                xArrList.Add(xArr);
            }
            return xArrList;
        }

        public static IList<double> Wiener(int seed, DateTime initialDate, DateTime finalDate, int numPoints)
        {
            var dwList = new double[numPoints];
            double dt = (finalDate - initialDate).TotalDays / numPoints;
            var random = new MersenneTwister(seed);

            Normal.Samples(random, dwList, 0.0, 1.0);
            dwList = dwList.Select(n => n * Math.Sqrt(dt)).ToArray();
            dwList[0] = 0;

            return dwList.ToList();
        }


        //微分方程式を解いたもの
        public static IList<double> GeoBrownianTrue(int seed, double initialValue, DateTime initialDate, DateTime finalDate, int numPoints, double mu, double sigma)
        {
            double[] wList = new double[numPoints];
            double dt = (finalDate - initialDate).TotalDays / numPoints;
            double[] tList = Enumerable.Range(0, numPoints).Select(n => dt * n).ToArray();

            var xZero = initialValue;
            var dwList = Wiener(seed, initialDate, finalDate, numPoints);

            wList[0] = dwList[0];
            for (int i = 1; i < numPoints; i++)
            {
                wList[i] = wList[i - 1] + dwList[i];
            }

            var tmp = tList.Zip(wList, (x, y) => new { x, y }).ToList();
            var yValues = tmp.Select(p => xZero * Math.Exp((mu - 0.5 * Math.Pow(sigma, 2)) * p.x + sigma * p.y)).ToList();
            return yValues;
        }


    }
}
