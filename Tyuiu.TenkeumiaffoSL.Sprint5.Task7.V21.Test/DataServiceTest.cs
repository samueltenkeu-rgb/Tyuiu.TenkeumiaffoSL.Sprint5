using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using Tyuiu.TenkeumiaffoSL.Sprint5.Task7.V21.Lib;

namespace Tyuiu.TenkeumiaffoSL.Sprint5.Task7.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestLoadDataAndSave()
        {
            DataService ds = new DataService();

            string inputPath = Path.Combine(Path.GetTempPath(), "TestInputFileTask7V21.txt");
            File.WriteAllText(inputPath, "Hello, Мир! Это Is My First Program.");

            string outputPath = ds.LoadDataAndSave(inputPath);

            Assert.IsTrue(File.Exists(outputPath));

            string resultText = File.ReadAllText(outputPath);
            string expected = "Hello Мир Это Is My First Program";

            Assert.AreEqual(expected, resultText);

            File.Delete(inputPath);
            File.Delete(outputPath);
        }
    }
}
