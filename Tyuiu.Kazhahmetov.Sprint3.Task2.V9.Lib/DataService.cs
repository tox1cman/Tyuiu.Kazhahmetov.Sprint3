using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.Kazhahmetov.Sprint3.Task2.V9.Lib
{
    public class DataService : ISprint3Task2V9
    {
        public double GetSumSeries(int value, int startValue, int stopValue)
        {
            double res = 0;
            do
            {
                double s = Math.Pow((1.0 / (Math.Pow(value, startValue))), 2);
                res += s;
                startValue++;
            }
            while ( startValue < stopValue );
            return Math.Round(res, 3);
        }
    }
}
