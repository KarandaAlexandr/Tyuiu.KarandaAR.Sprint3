using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.KarandaAR.Sprint3.Task4.V20.Lib
{
    public class DataService : ISprint3Task4V20
    {
        public double Calculate(int startValue, int stopValue)
        {
            double p = 1;
            for (int x = startValue; x < stopValue; x++)
            {
                if (x == 0)
                {
                    continue;
                }
                p *= x / (Math.Cos(x) - x) + 2.5;

            }
            return Math.Round(p, 3);
        }
    }
}
