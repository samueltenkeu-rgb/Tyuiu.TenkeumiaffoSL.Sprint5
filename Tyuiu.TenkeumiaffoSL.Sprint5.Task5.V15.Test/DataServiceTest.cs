using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using Tyuiu.TenkeumiaffoSL.Sprint5.Task5.V15.Lib;

namespace Tyuiu.TenkeumiaffoSL.Sprint5.Task5.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestLoadFromDataFile()
        {
            DataService ds = new DataService();

            // Создаем тестовый файл с данными
            string path = Path.Combine(Path.GetTempPath(), "TestFileTask5V15.txt");
            File.WriteAllText(path, "12.5 3.2 15 7.0 25 8.5 5");

            double result = ds.LoadFromDataFile(path);

            // Числа, делящиеся на 5: 15, 25, 5, 12.5
            // Минимальное из них: 5
            double expected = 5.0;

            Assert.AreEqual(expected, result);

            File.Delete(path);
        }
    }
}
