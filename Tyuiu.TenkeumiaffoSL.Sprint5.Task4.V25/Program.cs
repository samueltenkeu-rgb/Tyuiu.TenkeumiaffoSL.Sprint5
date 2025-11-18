using System;
using System.IO;
using Tyuiu.TenkeumiaffoSL.Sprint5.Task4.V25.Lib;

namespace Tyuiu.TenkeumiaffoSL.Sprint5.Task4.V25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #5 | Выполнил: Миаффо Тенкеу Лоик Сэмюэль | Вариант #25";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Чтение данных из текстового файла                                 *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #25                                                             *");
            Console.WriteLine("* Выполнил: Миаффо Тенкеу Лоик Сэмюэль | ИСТНб-25-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан файл, в котором есть вещественное значение. Прочитать значение     *");
            Console.WriteLine("* из файла и подставить вместо X в формуле.                               *");
            Console.WriteLine("* Вычислить значение по формуле y = (x^4 + cos(x)) * sin(x)               *");
            Console.WriteLine("* и вернуть результат на консоль.                                         *");
            Console.WriteLine("* Полученное значение округлить до трёх знаков после запятой.            *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string path = @"C:\DataSprint5\InPutDataFileTask4V25.txt";

            Console.WriteLine($"* Путь к файлу: {path}");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            try
            {
                DataService ds = new DataService();
                double result = ds.LoadFromDataFile(path);

                // Читаем значение x из файла для отображения
                string xValue = File.ReadAllText(path).Trim();
                Console.WriteLine($"Значение x из файла: {xValue}");
                Console.WriteLine($"Результат вычисления: {result}");
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
                Console.WriteLine("Убедитесь, что файл существует по пути: C:\\DataSprint5\\InPutDataFileTask4V25.txt");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }

            Console.WriteLine("***************************************************************************");
            Console.ReadKey();
        }
    }
}
