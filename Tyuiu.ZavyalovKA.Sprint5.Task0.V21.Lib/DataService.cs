using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
namespace Tyuiu.ZavyalovKA.Sprint5.Task0.V21.Lib
{
    public class DataService : ISprint5Task0V21
    {
        public string SaveToFileTextData(int x)
        {
            string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask0.txt";
            double z = (Math.Pow(x, 2) + 1) / Math.Sqrt(4 * Math.Pow(x, 2) - 3);
            z = Math.Round(z, 2);
            File.WriteAllText(path, Convert.ToString(z));
            return path;
        }
    }
}
