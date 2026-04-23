using System.Globalization;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.MautalievSI.Sprint5.Task5.V1.Lib
{
    public class DataService : ISprint5Task5V1
    {
        public double LoadFromDataFile(string path)
        {
            if (!File.Exists(path))
                throw new FileNotFoundException($"Файл не найден: {path}");

            string content = File.ReadAllText(path);
            string[] tokens = content.Split(new char[] { ' ', '\n', '\r', '\t' }, StringSplitOptions.RemoveEmptyEntries);

            double sum = 0;
            foreach (var token in tokens)
            {
                if (double.TryParse(token, NumberStyles.Any, CultureInfo.InvariantCulture, out double value))
                {
                    // Проверяем "делимость на 2" для вещественного числа
                    if (Math.Abs(value % 2) < 1e-9)
                        sum += value;
                }
            }

            return Math.Round(sum, 3);
        }
    }
}