using System;
using System.IO;
using Tyuiu.TenkeumiaffoSL.Sprint5.Task0.V18.Lib;

namespace Tyuiu.TenkeumiaffoSL.Sprint5.Task0.V18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #5 | Выполнил: Миаффо Тенкеу Лоик Сэмюэль | Вариант #18";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Запись данных в текстовый файл                                    *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #18                                                             *");
            Console.WriteLine("* Выполнил: Миаффо Тенкеу Лоик Сэмюэль | ИСТНб-25-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дано выражение y(x) = x / sqrt(x^2 + x), вычислить его при x = 3,      *");
            Console.WriteLine("* результат сохранить в текстовый файл OutPutFileTask0.txt и вывести на  *");
            Console.WriteLine("* консоль. Округлить до трёх знаков после запятой.                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();
            int x = 3;
            string path = ds.SaveToFileTextData(x);

            Console.WriteLine($"* При x = {x}                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine($"Результат сохранен в файл: {path}");
            Console.WriteLine("***************************************************************************");

            // Выведем содержимое файла
            string result = File.ReadAllText(path);
            Console.WriteLine($"Содержимое файла: {result}");
            Console.WriteLine("***************************************************************************");

            Console.ReadKey();
        }
    }
}
