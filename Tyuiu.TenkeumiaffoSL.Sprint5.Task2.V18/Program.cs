using System;
using System.IO;
using Tyuiu.TenkeumiaffoSL.Sprint5.Task2.V18.Lib;

namespace Tyuiu.TenkeumiaffoSL.Sprint5.Task2.V18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #5 | Выполнил: Миаффо Тенкеу Лоик Сэмюэль | Вариант #18";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Обработка файлов                                                  *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #18                                                             *");
            Console.WriteLine("* Выполнил: Миаффо Тенкеу Лоик Сэмюэль | ИСТНб-25-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан двумерный целочисленный массив 3 на 3 элементов,                     *");
            Console.WriteLine("* заполненный значениями с клавиатуры. Заменить положительные элементы     *");
            Console.WriteLine("* массива на 1, отрицательные на 0. Результат сохранить в файл            *");
            Console.WriteLine("* OutPutFileTask2.csv и вывести на консоль.                                *");
            Console.WriteLine("***************************************************************************");

            // Пример исходного массива
            int[,] matrix = new int[3, 3]
            {
                { 3, 8, 4 },
                { -5, -4, -3 },
                { -9, 0, 2 }
            };

            Console.WriteLine("Исходный массив:");
            PrintMatrix(matrix);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();
            string path = ds.SaveToFileTextData(matrix);

            Console.WriteLine("Преобразованный массив:");
            PrintMatrix(TransformMatrix(matrix));

            Console.WriteLine($"Результат сохранен в файл: {path}");
            Console.WriteLine("***************************************************************************");

            // Вывод содержимого файла
            Console.WriteLine("Содержимое файла:");
            string[] lines = File.ReadAllLines(path);
            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }

            Console.WriteLine("***************************************************************************");

            Console.ReadKey();
        }

        static void PrintMatrix(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"{matrix[i, j],4}");
                }
                Console.WriteLine();
            }
        }

        static int[,] TransformMatrix(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            int[,] result = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    result[i, j] = matrix[i, j] > 0 ? 1 : 0;
                }
            }

            return result;
        }
    }
}
