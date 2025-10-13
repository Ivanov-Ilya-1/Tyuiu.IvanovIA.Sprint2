using Tyuiu.IvanovIA.Sprint2.Task1.V11.Lib;
namespace Tyuiu.IvanovIA.Sprint2.Task1.V11.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetLogicOperation()
        {
            DataService ds = new DataService();
            bool[] res = new bool[6];
            int a = 145;
            int b = 156;
            int c = 142;
            int d = 117;
            res = ds.GetLogicOperations(a, b, c, d);
            bool[] wait = new bool[6] {false, false, true, false, true, false };
            CollectionAssert.AreEqual(wait, res);

        }
    }
}
