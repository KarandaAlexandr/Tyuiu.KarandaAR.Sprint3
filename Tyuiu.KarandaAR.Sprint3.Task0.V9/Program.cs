using Tyuiu.KarandaAR.Sprint3.Task0.V9.Lib;

namespace Tyuiu.KarandaAR.Sprint3.Task0.V9
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
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #9                                                              *");
            Console.WriteLine("* Выполнил: Каранда Александр Романович | АСОиУб-24-1                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, используя цикл for, которая вычисляет сумму ряда    *");
            Console.WriteLine("* по формуле, при x = 0.5.                                                *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");

            double x = 0.5;

            Console.WriteLine($"Сумма равна: {dataService.GetSumSeries(x, 1, 15)}");
        }
    }
}
