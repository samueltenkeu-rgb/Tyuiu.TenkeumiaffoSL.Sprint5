using System;
using System.IO;
using Tyuiu.TenkeumiaffoSL.Sprint5.Task7.V21.Lib;

namespace Tyuiu.TenkeumiaffoSL.Sprint5.Task7.V21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #5 | Выполнил: Миаффо Тенкеу Лоик Сэмюэль | Вариант #21";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Обработка текстовых данных                                        *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #21                                                             *");
            Console.WriteLine("* Выполнил: Миаффо Тенкеу Лоик Сэмюэль | ИСТНб-25-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан файл с символьными данными. Удалить все знаки препинания.           *");
            Console.WriteLine("* Сохранить результат в файл OutPutDataFileTask7V21.txt.                  *");
            Console.WriteLine("***************************************************************************");

            string inputPath = @"C:\DataSprint5\InPutDataFileTask7V21.txt";
            Console.WriteLine($"* Исходный файл: {inputPath}");
            Console.WriteLine("***************************************************************************");

            try
            {
                DataService ds = new DataService();
                string outputPath = ds.LoadDataAndSave(inputPath);

                if (File.Exists(inputPath))
                {
                    Console.WriteLine("Исходный текст:");
                    string originalText = File.ReadAllText(inputPath);
                    Console.WriteLine($"\"{originalText}\"");
                    Console.WriteLine("-----------------------------------------------------------------------");
                }

                if (File.Exists(outputPath))
                {
                    Console.WriteLine("Текст после удаления знаков препинания:");
                    string resultText = File.ReadAllText(outputPath);
                    Console.WriteLine($"\"{resultText}\"");
                    Console.WriteLine("-----------------------------------------------------------------------");
                }

                Console.WriteLine($"Результат сохранен в файл: {outputPath}");
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
                Console.WriteLine("Убедитесь, что файл существует по пути: C:\\DataSprint5\\InPutDataFileTask7V21.txt");
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
