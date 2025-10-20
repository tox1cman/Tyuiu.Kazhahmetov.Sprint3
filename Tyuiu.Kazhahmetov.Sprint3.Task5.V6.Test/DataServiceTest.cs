using Tyuiu.Kazhahmetov.Sprint3.Task5.V6.Lib;
namespace Tyuiu.Kazhahmetov.Sprint3.Task5.V6.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int startValue1 = 1;
            int startValue2 = 1;
            int stopValue1 = 3;
            int stopValue2 = 10;
            double wait = 40.917;
            double res = ds.GetSumSumSeries(startValue1, startValue2, stopValue1, stopValue2);
            Assert.AreEqual(wait, res);
        }
    }
}
