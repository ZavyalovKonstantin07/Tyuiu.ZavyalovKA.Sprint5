using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
using System.Security;
namespace Tyuiu.ZavyalovKA.Sprint5.Task7.V8.Lib
{
    public class DataService : ISprint5Task7V8
    {
        public string LoadDataAndSave(string path)
        {
            string strLine = "";
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    for (int i = 0; i < line.Length; i++)
                    {
                        char currentChar = line[i];
                        if (currentChar >= 'А' && currentChar <= 'Я')
                        {
                            strLine = strLine + (char)(currentChar + 32);
                        }
                        else
                        {
                            strLine = strLine + currentChar;
                        }
                    }
                }
            }
            return path;
        }
    }
}

