using Tyuiu.KarandaAR.Sprint3.Task1.V9.Lib;

namespace Tyuiu.KarandaAR.Sprint3.Task1.V9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService dataService = new DataService();

            Console.Title = "Спринт #3 | Выполнил: Каранда А. Р. | АСОиУб-24-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Циклы и последовательности                                        *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #9                                                              *");
            Console.WriteLine("* Выполнил: Каранда Александр Романович | АСОиУб-24-1                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, используя цикл while, которая вычисляет произведение*");
            Console.WriteLine("* ряда по формуле, при x = 5.                                             *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");

            int x = 5;

            Console.WriteLine($"Произведение равно: {dataService.GetMultiplySeries(x, 1, 4)}");

            Console.ReadKey();
        }
    }
}
