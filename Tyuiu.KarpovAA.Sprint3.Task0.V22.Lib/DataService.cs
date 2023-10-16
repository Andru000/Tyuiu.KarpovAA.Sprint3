using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.KarpovAA.Sprint3.Task0.V22.Lib
{
    public class DataService : ISprint3Task0V22
    {
        public double GetSumSeries(double value, int startValue, int stopValue)
        {
            double a = 0.25;
            double p = 1;

            for (int k = 1; k <= 8; k++)
            {
                p *= ((Math.Pow(a, k) + 4) * Math.Cos(a));
            }
            
            return Math.Round(p, 3);
        }
    }
}
