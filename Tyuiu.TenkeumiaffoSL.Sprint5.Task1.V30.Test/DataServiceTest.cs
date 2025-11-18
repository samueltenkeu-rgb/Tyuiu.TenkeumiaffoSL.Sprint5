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

            Assert.IsTrue(File.Exists(path));

            string fileContent = File.ReadAllText(path).Trim().Replace("\r", "");

            // Проверка значений функции f(x) = cos(x) + sin(x)/(2-2x) - 4x
            string[] expectedValues = new string[11];
            for (int i = 0; i <= stopValue - startValue; i++)
            {
                int x = startValue + i;
                double value;
                if (2 - 2 * x == 0)
                    value = 0;
                else
                    value = Math.Cos(x) + (Math.Sin(x) / (2 - 2 * x)) - 4 * x;

                value = Math.Round(value, 2);
                expectedValues[i] = value.ToString();
            }

            string expected = string.Join("\n", expectedValues);

            Assert.AreEqual(expected, fileContent);
        }
    }
}
