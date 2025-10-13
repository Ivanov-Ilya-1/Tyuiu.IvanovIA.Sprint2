using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.IvanovIA.Sprint2.Task0.V24.Lib
{
    public class DataService : ISprint2Task0V24
    {
        public bool[] GetCompareOperations(int x, int y)
        {
            bool[] res = new bool[6];

            res[0] = (620 + x) == y;
            res[1] = x != y;
            res[2] = y < x;
            res[3] = x > y;
            res[4] = (620 + x) <= y;
            res[5] = (630 + x) >= y;

            return res;

        }
    }
}