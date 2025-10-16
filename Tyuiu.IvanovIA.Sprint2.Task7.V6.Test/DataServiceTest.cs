using Tyuiu.IvanovIA.Sprint2.Task7.V6.Lib;
namespace Tyuiu.IvanovIA.Sprint2.Task7.V6.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckDotInShadowArea()
        {
            DataService ds = new DataService();

            double x = 1;
            double y = 1;
            bool res = ds.CheckDotInShadedArea(x,y);
            bool wait = true;
            Assert.AreEqual(wait,res);
        }
    }
}
