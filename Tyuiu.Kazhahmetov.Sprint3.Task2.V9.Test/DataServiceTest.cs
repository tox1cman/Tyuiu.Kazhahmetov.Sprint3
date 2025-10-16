using Tyuiu.Kazhahmetov.Sprint3.Task2.V9.Lib;
namespace Tyuiu.Kazhahmetov.Sprint3.Task2.V9.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int startValue = 1;
            int stopValue = 10;
            int Value = 5;
            double res = ds.GetSumSeries(Value, startValue, stopValue);
            double wait = 0.042;
            Assert.AreEqual(wait, res);

        }
    }
}
