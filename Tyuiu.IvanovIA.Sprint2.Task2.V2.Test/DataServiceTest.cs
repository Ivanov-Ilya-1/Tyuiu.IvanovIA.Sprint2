using Tyuiu.IvanovIA.Sprint2.Task2.V2.Lib;
namespace Tyuiu.IvanovIA.Sprint2.Task2.V2.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValisCheckDotInShadedArea()
        {
            DataService ds  = new DataService();
            int x = 6;
            int y = 6;

            bool res = ds.CheckDotInShadedArea(x, y);
            bool wait = true;
            Assert.AreEqual(wait, res);
        }
    }
}
