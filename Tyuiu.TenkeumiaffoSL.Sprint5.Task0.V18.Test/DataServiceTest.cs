using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using Tyuiu.TenkeumiaffoSL.Sprint5.Task0.V18.Lib;

namespace Tyuiu.TenkeumiaffoSL.Sprint5.Task0.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestSaveToFileTextData()
        {
            DataService ds = new DataService();
            int x = 3;
            string path = ds.SaveToFileTextData(x);

            Assert.IsTrue(File.Exists(path));

            string result = File.ReadAllText(path);

            // Проверка: y(3) = 3 / sqrt(9 + 3) = 3 / sqrt(12) ≈ 0.866
            Assert.AreEqual("0,866", result);
        }
    }
}
