using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.KarandaAR.Sprint3.Task6.V4.Lib
{
    public class DataService : ISprint3Task6V4
    {
        public int GetSumTheDivisors(int startValue, int stopValue)
        {
            int summa = 1;
            for (int number = startValue; number <= stopValue; number++)
            {
                for (int i = 9; i <= number; i++)
                {
                    if (number % i == 0)
                    {
                        summa++;
                    }
                }
            }
            return summa;
        }
    }
}
