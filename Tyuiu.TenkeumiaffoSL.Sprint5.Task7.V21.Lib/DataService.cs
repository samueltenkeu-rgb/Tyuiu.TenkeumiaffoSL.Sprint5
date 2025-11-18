using System;
using System.IO;
using System.Text;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.TenkeumiaffoSL.Sprint5.Task7.V21.Lib
{
    public class DataService : ISprint5Task7V21
    {
        public string LoadDataAndSave(string path)
        {
            if (!File.Exists(path))
                throw new FileNotFoundException($"Файл не найден: {path}");

            string text = File.ReadAllText(path);

            StringBuilder resultBuilder = new StringBuilder();

            foreach (char c in text)
            {
                // Убираем знаки препинания
                if (!char.IsPunctuation(c))
                {
                    resultBuilder.Append(c);
                }
            }

            string resultText = resultBuilder.ToString();

            string outputPath = Path.Combine(Path.GetTempPath(), "OutPutDataFileTask7V21.txt");
            File.WriteAllText(outputPath, resultText);

            return outputPath;
        }
    }
}
