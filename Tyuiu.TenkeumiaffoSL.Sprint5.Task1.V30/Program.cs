using System;
using System.IO;
using Tyuiu.TenkeumiaffoSL.Sprint5.Task1.V30.Lib;

namespace Tyuiu.TenkeumiaffoSL.Sprint5.Task1.V30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #5 | Выполнил: Миаффо Тенкеу Лоик Сэмюэль | Вариант #30";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Табулирование функции                                             *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #30                                                             *");
            Console.WriteLine("* Выполнил: Миаффо Тенкеу Лоик Сэмюэль | ИСТНб-25-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дана функция: f(x) = cos(x) + sin(x)/(2-2x) - 4x                        *");
            Console.WriteLine("* Произвести табулирование f(x) на диапазоне [-5; 5] с шагом 1.           *");
            Console.WriteLine("* Произвести проверку деления на ноль. При делении на ноль вернуть 0.     *");
            Console.WriteLine("* Результат сохранить в файл OutPutFileTask1.txt и вывести на консоль.    *");
            Console.WriteLine("* Значения округлить до двух знаков после запятой.                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int startValue = -5;
            int stopValue = 5;

            Console.WriteLine($"* Стартовое значение x: {startValue}                                      *");
            Console.WriteLine($"* Конечное значение x: {stopValue}                                        *");
            Console.WriteLine($"* Шаг: 1                                                                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();
            string path = ds.SaveToFileTextData(startValue, stopValue);

            Console.WriteLine($"Результат сохранен в файл: {path}");
            Console.WriteLine("***************************************************************************");

            // Вывод содержимого файла в виде таблицы
            Console.WriteLine("Таблица значений функции:");
            Console.WriteLine("x\tf(x)");
            Console.WriteLine("----------------");

            string[] lines = File.ReadAllLines(path);
            int x = startValue;
            foreach (string line in lines)
            {
                Console.WriteLine($"{x}\t{line}");
                x++;
            }

            Console.WriteLine("***************************************************************************");

            Console.ReadKey();
        }
    }
}
