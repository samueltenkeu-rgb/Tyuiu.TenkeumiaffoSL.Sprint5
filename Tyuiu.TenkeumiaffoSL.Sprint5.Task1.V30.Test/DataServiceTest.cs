using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using Tyuiu.TenkeumiaffoSL.Sprint5.Task1.V30.Lib;

namespace Tyuiu.TenkeumiaffoSL.Sprint5.Task1.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestSaveToFileTextData()
        {
            DataService ds = new DataService();

            int startValue = -5;
            int stopValue = 5;
            string path = ds.SaveToFileTextData(startValue, stopValue);

            string fileContent = File.ReadAllText(path).Trim().Replace("\r", "");

            // Проверка значений функции
            // f(x) = cos(x) + sin(x)/(2-2x) - 4x
            string expected = "-22,25\n-17,91\n-13,91\n-10,26\n-6,96\n-4,02\n-1,45\n0,46\n2,12\n3,56\n4,87";

            Assert.AreEqual(expected, fileContent);
        }
    }
}
