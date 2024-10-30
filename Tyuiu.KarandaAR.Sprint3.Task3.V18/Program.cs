using Tyuiu.KarandaAR.Sprint3.Task3.V18.Lib;

namespace Tyuiu.KarandaAR.Sprint3.Task3.V18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService dataService = new DataService();

            Console.Title = "Спринт #3 | Выполнил: Каранда А. Р. | АСОиУб-24-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Оператор цикла foreach                                            *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #18                                                             *");
            Console.WriteLine("* Выполнил: Каранда Александр Романович | АСОиУб-24-1                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Используя цикл foreach заменить цифры на букву n в строке: 4n5nvf 56 bgy*");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");

            string str = "4n5nvf 56 bgy";

            Console.WriteLine($"Преобразованная строка: {dataService.ReplaceNumOnChar(str, 'n')}");

            Console.ReadKey();
        }
    }
}
