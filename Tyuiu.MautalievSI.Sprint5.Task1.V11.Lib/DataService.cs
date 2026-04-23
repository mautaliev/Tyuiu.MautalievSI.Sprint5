using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.MautalievSI.Sprint5.Task1.V11.Lib
{
    public class DataService : ISprint5Task1V25
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            // Устанавливаем путь к файлу
            string filePath = Path.Combine(Path.GetTempPath(), "OutPutFileTask1.txt");

            // Создаем текстовый файл
            using (StreamWriter writer = new StreamWriter(filePath))
            {

                // Выводим таблицу на консоль
                string text = "";
                // Проходим по диапазону значений
                for (int x = startValue; x <= stopValue; x++)
                {
                    double fx = CalculateFunction(x);

                    fx = Math.Round(fx, 2);
                    if (fx % 1 == 0)
                    {
                        fx = Convert.ToInt32(fx);
                    }
                    text += fx.ToString() + "\n";
                }
                text = text.Replace('.', ',');
                Console.WriteLine(text);
                writer.Write(text);
            }

            return filePath;
        }

        private double CalculateFunction(int x)
        {
            // Проверка деления на ноль (если знаменатель равен 0, возвращаем 0)
            double denominator = 3 * x + 1.2;
            if (denominator == 0)
            {
                return 0;
            }

            // Вычисляем F(x)
            double fx = (2 * Math.Sin(x) / denominator) + Math.Cos(x) - 7 * x * 2;

            return fx;
        }
    }
}
