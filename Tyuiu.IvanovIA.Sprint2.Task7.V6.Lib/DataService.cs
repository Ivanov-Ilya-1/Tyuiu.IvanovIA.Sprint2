using System;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.IvanovIA.Sprint2.Task7.V6.Lib
{
    public class DataService : ISprint2Task7V6
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            bool res;

            
            if ((Math.Pow(x, 2) + Math.Pow(y, 2) <= 4) && (y >= 0) && (x >= -2 && x <= 2))
            {
                res = true;
            }
            else if ((Math.Pow(x, 2) + Math.Pow(y, 2) <= 4) && (y >= 0) && (x >= -1 && x <= 1))
            {
                res = false;
            }
            else
            {
                return false;
            }

            return res;
        }
    }
}