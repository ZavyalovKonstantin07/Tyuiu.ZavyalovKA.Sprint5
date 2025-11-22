using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.ZavyalovKA.Sprint5.Task4.V29.Lib
{
    public class DataService : ISprint5Task4V29
    {
        public double LoadFromDataFile(string path)
        {
            string strX = File.ReadAllText(path);
            strX = strX.Trim().Replace(" ", "").Replace("\n", "").Replace("\r", "").Replace("\t", "");
            strX = strX.Replace(",", ".");
            double x = double.Parse(strX, System.Globalization.CultureInfo.InvariantCulture);
            double res = (x / (2 * x)) + Math.Sin(Math.Pow(x, 2));
            return Math.Round(res, 3);
        }
    }
}
