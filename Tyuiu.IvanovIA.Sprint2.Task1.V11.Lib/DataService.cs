using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.IvanovIA.Sprint2.Task1.V11.Lib
{
    public class DataService : ISprint2Task1V11
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] res = new bool[6];

            res[0] = (a == b) | (c > b);
            res[1] = (d >= c) & (b > c);
            res[2] = !(c >= b);
            res[3] = (d >= c) || (a <= d);
            res[4] = (b > c) ^ (a == d);
            res[5] = (a != b) && (a == c);

            return res;
        }
    }
}
