using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using Tyuiu.TenkeumiaffoSL.Sprint5.Task6.V12.Lib;

namespace Tyuiu.TenkeumiaffoSL.Sprint5.Task6.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestLoadFromDataFile()
        {
            DataService ds = new DataService();

            // Создаем тестовый файл с данными
            string path = Path.Combine(Path.GetTempPath(), "TestFileTask6V12.txt");
            File.WriteAllText(path, "Анна ненавидит ненастье.");

            int result = ds.LoadFromDataFile(path);

            // учитываются только последовательные 'нн'
            int expected = 1;

            Assert.AreEqual(expected, result);

            File.Delete(path);
        }
    }
}
