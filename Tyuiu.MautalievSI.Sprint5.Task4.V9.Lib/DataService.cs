using System.Globalization;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.MautalievSI.Sprint5.Task4.V9.Lib
{
    public class DataService : ISprint5Task4V9
    {
        public double LoadFromDataFile(string path)
        {
            string X = File.ReadAllText(path);
            double strX = double.Parse(X, CultureInfo.InvariantCulture);
            double res = Math.Round((1 / Math.Sin(Convert.ToDouble(strX)) + Convert.ToDouble(strX) * Convert.ToDouble(strX)), 3);
            return res;
        }
    }
}