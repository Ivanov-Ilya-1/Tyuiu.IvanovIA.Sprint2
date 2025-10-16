using Tyuiu.IvanovIA.Sprint2.Task4.V8.Lib;
namespace Tyuiu.IvanovIA.Sprint2.Task4.V8.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidConditional1()
        {
            DataService ds = new DataService();
            double x = 10;
            double y = 1;
            double res = ds.Calculate(x,y);
            double wait = 5;
            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void ValidConditional2()
        {
            DataService ds = new DataService();
            double x = 7;
            double y = 2;
            double res = ds.Calculate(x,y);
            double wait = 106.5;
            Assert.AreEqual(wait, res);
        }
    }
}
