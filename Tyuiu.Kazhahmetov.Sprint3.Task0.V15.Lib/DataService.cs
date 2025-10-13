using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.Kazhahmetov.Spritn3.Task0.V15.Lib
{
    public class DataService : ISprint3Task0V15
    {
        public double GetSumSeries(double value, int startValue, int stopValue)
        {
            double s = 0;
            for (int i = startValue; i <= stopValue; i++)
            {
                double res = ((Math.Pow(value, i)) + (2.0 / (i + 1))) * (Math.Sin(value));
                s += res;
            }
            return Math.Round(s, 3);
        }
    }
}
