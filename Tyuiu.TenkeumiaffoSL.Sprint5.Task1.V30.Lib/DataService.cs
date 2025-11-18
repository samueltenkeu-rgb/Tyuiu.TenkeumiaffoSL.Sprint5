using System;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.TenkeumiaffoSL.Sprint5.Task1.V30.Lib
{
    public class DataService : ISprint5Task1V30
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask1.txt");

            using (StreamWriter writer = new StreamWriter(path))
            {
                for (int x = startValue; x <= stopValue; x++)
                {
                    double value;

                    // Проверка деления на ноль
                    if (2 - 2 * x == 0)
                    {
                        value = 0;
                    }
                    else
                    {
                        value = Math.Cos(x) + (Math.Sin(x) / (2 - 2 * x)) - 4 * x;
                        value = Math.Round(value, 2);
                    }

                    writer.WriteLine(value.ToString());
                }
            }

            return path;
        }
    }
}
