using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.MautalievSI.Sprint5.Task0.V30.Lib
{
    public class DataService : ISprint5Task0V30
    {
        public string SaveToFileTextData(int x)
        {
            double y = (Math.Pow(x, 2) + 1) / (3 * x + 4);
            y = Math.Round(y, 3);
            string filePath = Path.Combine(Path.GetTempPath(), "OutPutFileTask0.txt");
            File.WriteAllText(filePath, y.ToString());
            return filePath;
        }
    }
}
