using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.Kazhahmetov.Sprint3.Task5.V6.Lib
{
    public class DataService : ISprint3Task5V6
    {
        public double GetSumSumSeries(int startValue1, int startValue2, int stopValue1, int stopValue2)
        {
            double res = 0;
            for (int k = startValue1; k <= stopValue1; k++)
            {
                for (int j = startValue2; j <= stopValue2; j++)
                {
                    res = res + (1 / (Math.Cos(j))) + 2;
                }
            }
            return Math.Round(res, 3);
        }
    }
}
