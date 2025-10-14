using Tyuiu.Kazhahmetov.Sprint3.Task1.V7.Lib;
namespace Tyuiu.Kazhahmetov.Sprint3.Task1.V7.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double value = 0.25;
            int starValue = 1;
            int stopValue = 9;
            double res = ds.GetMultiplySeries(value, starValue, stopValue);
            double wait = -0.93;
            Assert.AreEqual(wait, res);
        }
    }
}
