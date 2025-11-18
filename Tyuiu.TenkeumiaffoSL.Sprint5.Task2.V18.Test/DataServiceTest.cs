using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using Tyuiu.TenkeumiaffoSL.Sprint5.Task2.V18.Lib;

namespace Tyuiu.TenkeumiaffoSL.Sprint5.Task2.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestSaveToFileTextData()
        {
            DataService ds = new DataService();

            int[,] matrix = new int[3, 3]
            {
                { 3, 8, 4 },
                { -5, -4, -3 },
                { -9, 0, 2 }
            };

            string path = ds.SaveToFileTextData(matrix);

            Assert.IsTrue(File.Exists(path));

            string[] lines = File.ReadAllLines(path);

            Assert.AreEqual(3, lines.Length);
            Assert.AreEqual("1;1;1", lines[0]);
            Assert.AreEqual("0;0;0", lines[1]);
            Assert.AreEqual("0;0;1", lines[2]);
        }
    }
}
