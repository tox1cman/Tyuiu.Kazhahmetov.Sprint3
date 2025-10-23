using Tyuiu.Kazhahmetov.Sprint3.Task7.V9.Lib;
namespace Tyuiu.Kazhahmetov.Sprint3.Task7.V9.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int startValue = -5;
            int stopValue = 5;

            int len = (stopValue - startValue) + 1;

            double[] valueCheck;
            valueCheck = new double[len];

            valueCheck[0] = 0;
            valueCheck[1] = 0;
            valueCheck[2] = 0;
            valueCheck[3] = 0;
            valueCheck[4] = 0;
            valueCheck[5] = 0;
            valueCheck[6] = 0;
            valueCheck[7] = 0;
            valueCheck[8] = 0;
            valueCheck[9] = 0;
            valueCheck[10] = 0;

            double[] res;
            res = new double[len];
            res = ds.GetMassFunction(startValue, stopValue);
            CollectionAssert.AreEqual(valueCheck, res);
        }
    }
}
