using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.KarandaAR.Sprint3.Task7.V2.Lib
{
    public class DataService : ISprint3Task7V2
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int length = stopValue - startValue + 1;
            double[] results = new double[length];
            int index = 0;

            for (int x = startValue; x <= stopValue; x++)
            {
                if (x == 0.7)
                {
                    results[index] = 0;
                }
                else
                {
                    results[index] = Math.Round((Math.Cos(x) / (x - 0.7)) - (Math.Sin(x) * 12 * x) + 2, 2);
                }

                index++;
            }

            return results;
        }
    }
}
