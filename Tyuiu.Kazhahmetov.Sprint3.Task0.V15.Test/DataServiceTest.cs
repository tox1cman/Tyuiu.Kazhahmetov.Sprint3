using Tyuiu.Kazhahmetov.Spritn3.Task0.V15.Lib;
namespace Tyuiu.Kazhahmetov.Spritn3.Task0.V15.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double value = 0.7;
            int startValue = 1;
            int stopValue = 10;
            double res = ds.GetSumSeries(value, startValue, stopValue);
            double wait = 2.1;
            Assert.AreEqual(wait, res);
        }
    }
}
