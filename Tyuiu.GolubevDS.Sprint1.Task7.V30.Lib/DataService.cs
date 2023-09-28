using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.GolubevDS.Sprint1.Task7.V30.Lib
{
    public class DataService : ISprint1Task7V30
    {
        public double Calculate(double x, double y)
        {
            double res = ((x + Math.Pow(Math.E, x) + Math.Pow(Math.Sin(x), 5) * Math.Pow(x, 3)) / 3 * Math.Pow(x, 2) + (Math.Pow(5, y) / Math.Pow(y, 5)));

            return res;
        }
    }
}
