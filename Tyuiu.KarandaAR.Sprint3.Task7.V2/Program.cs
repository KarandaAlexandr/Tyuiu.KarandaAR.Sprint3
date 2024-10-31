using Tyuiu.KarandaAR.Sprint3.Task7.V2.Lib;

namespace Tyuiu.KarandaAR.Sprint3.Task7.V2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService dataService = new DataService();

            Console.Title = "Спринт #3 | Выполнил: Каранда А. Р. | АСОиУб-24-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Табулирование функции                                             *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #2                                                              *");
            Console.WriteLine("* Выполнил: Каранда Александр Романович | АСОиУб-24-1                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая выводит таблицу значений функции:           *");
            Console.WriteLine("* F(x) = cos(x) / (x - 0.7) - sin(x) * 12x + 2                            *");
            Console.WriteLine("* на диапазоне [-5; 5] с шагом 1                                          *");
            Console.WriteLine("* Проверить деление на ноль, при делении на ноль вернуть значение 0       *");
            Console.WriteLine("* Округлить до двух знаков после запятой                                  *");
            Console.WriteLine("***************************************************************************");

            int startValue = -5;
            int stopValue = 5;

            double[] results = dataService.GetMassFunction(startValue, stopValue);

            // Выводим заголовок таблицы
            Console.WriteLine("Таблица значений функции:");
            Console.WriteLine(" X |   F(X)  ");
            Console.WriteLine("----|---------");

            int x = startValue;

            foreach (double result in results)
            {
                Console.WriteLine($"{x,2} | {result,7:F2}");
                x++;
            }
        }
    }
}
