using System.Text.RegularExpressions;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.MautalievSI.Sprint5.Task7.V12.Lib
{
    public class DataService : ISprint5Task7V12
    {
        public string LoadDataAndSave(string path)
        {
            string resPath = Path.Combine(Path.GetTempPath(), "OutPutFileTask7V12.txt");

            FileInfo fileInfo = new FileInfo(resPath);
            bool fileExsists = fileInfo.Exists;

            if (fileExsists) { File.Delete(resPath); }

            string str = File.ReadAllText(path);
            string[] word = str.Split(' ');

            for (int i = 0; i < word.Length; i++)
            {

                if (Regex.IsMatch(word[i], "[А-Я]"))
                {
                    word[i] = word[i].ToUpper();
                }

            }
            File.WriteAllText(resPath, String.Join(" ", word));

            return resPath;
        }
    }
}