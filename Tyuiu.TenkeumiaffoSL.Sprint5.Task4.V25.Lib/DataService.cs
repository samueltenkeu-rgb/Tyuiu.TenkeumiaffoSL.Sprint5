using System;
using System.Globalization;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.TenkeumiaffoSL.Sprint5.Task4.V25.Lib
{
    public class DataService : ISprint5Task4V25
    {
        public double LoadFromDataFile(string path)
        {
            if (!File.Exists(path))
                throw new FileNotFoundException($"Файл не найден: {path}");

            // Читаем значение из файла
            string text = File.ReadAllText(path).Trim();

            // Заменяем запятую на точку для корректного парсинга
            double x = double.Parse(text.Replace(",", "."), CultureInfo.InvariantCulture);

            // Вычисляем значение по формуле: y = (x^4 + cos(x)) * sin(x)
            double y = (Math.Pow(x, 4) + Math.Cos(x)) * Math.Sin(x);

            // Округляем до трех знаков после запятой
            return Math.Round(y, 3);
        }
    }
}
