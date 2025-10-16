using Tyuiu.IvanovIA.Sprint2.Task3.V15.Lib;
namespace Tyuiu.IvanovIA.Sprint2.Task3.V15.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidConditional1()
        {
            DataService ds = new DataService();
            double x = 10;
            double res = ds.Calculate(x);
            double wait = 17.439;
            Assert.AreEqual(wait,res);
        }
        [TestMethod]
        public void ValidConditional2()
        {
            DataService ds = new DataService();
            double x = 0;
            double res = ds.Calculate(x);
            double wait = 0.75;
            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void ValidConditional3()
        {
            DataService ds = new DataService();
            double x = -1;
            double res = ds.Calculate(x);
            double wait = 256;
            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void ValidConditional4()
        {
            DataService ds = new DataService();
            double x = -20;
            double res = ds.Calculate(x);
            double wait = -219.95;
            Assert.AreEqual(wait, res);
        }
    }
}
