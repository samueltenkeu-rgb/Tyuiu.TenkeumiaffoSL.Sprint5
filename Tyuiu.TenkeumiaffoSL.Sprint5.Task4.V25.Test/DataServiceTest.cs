using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.TenkeumiaffoSL.Sprint5.Task4.V25.Lib;

namespace Tyuiu.TenkeumiaffoSL.Sprint5.Task4.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestLoadFromDataFile()
        {
            DataService ds = new DataService();

            // Создаем тестовый файл
            string path = Path.Combine(Path.GetTempPath(), "TestFileTask4V25.txt");
            File.WriteAllText(path, "2.0");

            double result = ds.LoadFromDataFile(path);

            // Проверяем вычисление для x = 2.0
            // y = (2^4 + cos(2)) * sin(2)
            double expected = Math.Round((Math.Pow(2, 4) + Math.Cos(2)) * Math.Sin(2), 3);

            Assert.AreEqual(expected, result);

            File.Delete(path);
        }
    }
}
