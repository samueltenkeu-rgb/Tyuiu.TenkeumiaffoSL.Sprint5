using System;
using System.Globalization;
using System.IO;
using System.Linq;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.TenkeumiaffoSL.Sprint5.Task5.V15.Lib
{
    public class DataService : ISprint5Task5V16
    {
        public double LoadFromDataFile(string path)
        {
            if (!File.Exists(path))
                throw new FileNotFoundException($"Файл не найден: {path}");

            // Читаем все строки из файла
            string[] lines = File.ReadAllLines(path);

            double? minDivisibleBy5 = null;

            foreach (string line in lines)
            {
                // Разделяем строку на числа по пробелам
                string[] numbers = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                foreach (string numberStr in numbers)
                {
                    try
                    {
                        // Парсим число, заменяя точку на запятую для корректного парсинга
                        string normalizedNumber = numberStr.Replace(".", ",");
                        double number = double.Parse(normalizedNumber, CultureInfo.InvariantCulture);

                        // Проверяем делимость на 5
                        if (Math.Abs(number % 5) < 1e-10)
                        {
                            if (minDivisibleBy5 == null || number < minDivisibleBy5)
                                minDivisibleBy5 = number;
                        }
                    }
                    catch (FormatException)
                    {
                        continue; // Пропускаем некорректные данные
                    }
                }
            }

            if (minDivisibleBy5 == null)
                throw new Exception("В файле нет чисел, делящихся на 5");

            // Округляем до 3 знаков после запятой
            return Math.Round(minDivisibleBy5.Value, 3);
        }
    }
}
