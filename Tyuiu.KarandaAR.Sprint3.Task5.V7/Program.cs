using Tyuiu.KarandaAR.Sprint3.Task5.V7.Lib;

namespace Tyuiu.KarandaAR.Sprint3.Task5.V7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService dataService = new DataService();

            Console.Title = "Спринт #3 | Выполнил: Каранда А. Р. | АСОиУб-24-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Вложенные циклы                                                   *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #7                                                              *");
            Console.WriteLine("* Выполнил: Каранда Александр Романович | АСОиУб-24-1                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая вычисляет значение Y по следующей формуле:  *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("*              3       10                                                 *");
            Console.WriteLine("*             ---      ---        1                                       *");
            Console.WriteLine("*      Y =     \\        \\     -----  + x                                *");
            Console.WriteLine("*             /__ i=1  /__ k=1  cos(k)                                    *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine($"Произведение: {dataService.GetSumSumSeries(5, 1, 3, 1, 10)}");

            Console.ReadKey();
        }
    }
}
