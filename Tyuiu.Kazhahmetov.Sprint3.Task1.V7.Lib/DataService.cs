using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.Kazhahmetov.Sprint3.Task1.V7.Lib
{
    public class DataService : ISprint3Task1V7
    {
        public double GetMultiplySeries(double value, int startValue, int stopValue)
        {
            double res = 1;
            while(startValue <= stopValue)
            {
                double p = (Math.Pow(value, startValue) + 1) * Math.Sin(5);
                res *= p;
                startValue++;
            }
            return Math.Round(res, 2);
        }
    }
}
