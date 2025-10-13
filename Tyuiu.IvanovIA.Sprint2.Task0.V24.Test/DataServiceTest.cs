using Tyuiu.IvanovIA.Sprint2.Task0.V24.Lib;
namespace Tyuiu.IvanovIA.Sprint2.Task0.V24.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetCompareOperation()
        {
            DataService ds = new DataService();
            int x = 135;
            int y = 755;
            bool[] res = new bool[6];
            res = ds.GetCompareOperations(x, y);
            bool[] wait = new bool[6] { true, true, false, false, true, true };

            CollectionAssert.AreEqual(wait, res);
        }
    }
}