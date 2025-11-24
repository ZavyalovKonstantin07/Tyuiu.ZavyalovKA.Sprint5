using System.IO;
using System.Reflection;
using System.Security;
using System.Text;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.ZavyalovKA.Sprint5.Task7.V8.Lib
{
    public class DataService : ISprint5Task7V8
    {
        public string LoadDataAndSave(string path)
        {
            string pathSaveFile = @"C:\Users\Завьялов Константин\source\repos\Tyuiu.ZavyalovKA.Sprint5\Tyuiu.ZavyalovKA.Sprint5.Task7.V8\bin\Debug\net8.0\OutPutDataFileTask7V8.txt";
            FileInfo fileInfo = new FileInfo(pathSaveFile);
            bool FileExist = fileInfo.Exists;

            if (FileExist)
            {
                File.Delete(pathSaveFile);
            }

            string strLine = "";
            using (StreamReader reader = new(path))
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
                        File.AppendAllText(pathSaveFile, strLine);
                        strLine = "";
                    }
                }
            }
            return pathSaveFile;
        }
    }
}

