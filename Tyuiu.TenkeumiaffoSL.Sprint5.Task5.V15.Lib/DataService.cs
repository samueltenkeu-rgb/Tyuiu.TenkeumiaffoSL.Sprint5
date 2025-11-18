using System;
using System.Globalization;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.TenkeumiaffoSL.Sprint5.Task5.V15.Lib
{
    public class DataService : ISprint5Task5V16
    {
        public double LoadFromDataFile(string path)
        {
            if (!File.Exists(path))
                throw new FileNotFoundException($"Файл не найден: {path}");

            string[] lines = File.ReadAllLines(path);
            double? minDivisibleBy5 = null;

            foreach (string line in lines)
            {
                string[] numbers = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                foreach (string numberStr in numbers)
                {
                    try
                    {
                        string normalizedNumber = numberStr.Replace(".", ",");
                        double number = double.Parse(normalizedNumber, CultureInfo.InvariantCulture);

                        // Только положительные числа, делящиеся на 5
                        if (number > 0 && Math.Abs(number % 5) < 1e-10)
                        {
                            if (minDivisibleBy5 == null || number < minDivisibleBy5)
                                minDivisibleBy5 = number;
                        }
                    }
                    catch (FormatException)
                    {
                        continue;
                    }
                }
            }

            if (minDivisibleBy5 == null)
                throw new Exception("В файле нет положительных чисел, делящихся на 5");

            return Math.Round(minDivisibleBy5.Value, 3);
        }
    }
}
