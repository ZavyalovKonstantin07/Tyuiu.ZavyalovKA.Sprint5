using System.IO;
using System.Reflection.PortableExecutable;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.ZavyalovKA.Sprint5.Task5.V15.Lib
{
    public class DataService : ISprint5Task5V15
    {
        public double LoadFromDataFile(string path)
        {
            double z = double.MaxValue;

            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (double.TryParse(line.Trim(), out double number) && number % 5 == 0)
                    {
                        if (number < z)
                            z = number;
                    }
                }
            }
            return z == double.MaxValue ? 0 : z;
        }
    }
}


          
