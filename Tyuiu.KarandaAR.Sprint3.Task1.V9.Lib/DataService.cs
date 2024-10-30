using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.KarandaAR.Sprint3.Task1.V9.Lib
{
    public class DataService : ISprint3Task1V9
    {
        public double GetMultiplySeries(int value, int startValue, int stopValue)
        {
            double p = 0;
            for (int k = startValue; k <= stopValue; k++)
            {
                p += Math.Pow(300 / (Math.Cos(value) + Math.Pow(value, k)), k);
            }
            return Math.Round(p, 2);
        }
    }
}
