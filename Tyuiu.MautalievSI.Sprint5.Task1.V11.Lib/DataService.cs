using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.MautalievSI.Sprint5.Task1.V11.Lib
{
    public class DataService : ISprint5Task1V11
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            DataService ds = new();
            string path = Path.GetTempFileName();
            double y;
            string str;
            for (int x = startValue; x <= stopValue; x++)
            {
                y = ds.Calculate(x);
                str = Convert.ToString(y);
                if (x != stopValue)
                {
                    File.AppendAllText(path, str + Environment.NewLine);
                }
                else
                {
                    File.AppendAllText(path, str);
                }
            }
            return path;

        }
        public double Calculate(int x)
        {
            if (3 * x - 1 == 0)
            {
                return 0;
            }
            else
            {
                double F = Math.Round((Math.Sin(x) - 2 * x) / (3 * x - 1) + Math.Sin(x) - 3 * x + 2, 2);
                return F;
            }
        }
    }
}