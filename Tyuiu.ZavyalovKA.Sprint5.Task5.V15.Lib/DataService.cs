using System.IO;
using System.Reflection.PortableExecutable;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.ZavyalovKA.Sprint5.Task5.V15.Lib
{
    public class DataService : ISprint5Task5V15
    {
        public double LoadFromDataFile(string path)
        {
            double min = double.MaxValue;
            string allText = File.ReadAllText(path);
            string[] numbers = allText.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            foreach (string numStr in numbers)
            {
                string cleanNum = numStr.Trim().Replace(",", ".");
                if (double.TryParse(cleanNum, out double number))
                {
                    if(number % 5 == 0 && number > 0 && number < min)
                    {
                        min = number;
                    }
                }
            }
            return min == double.MaxValue ? 0 : min;
        } 
    }
}




