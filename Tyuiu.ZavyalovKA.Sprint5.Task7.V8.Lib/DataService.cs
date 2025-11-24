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
                string tempFile = Path.GetTempFileName();
                string pathSaveFile = Path.Combine(Path.GetDirectoryName(tempFile), "OutPutDataFileTask7V8.txt");
                File.Delete(tempFile);
                string text = File.ReadAllText(path);
                StringBuilder result = new StringBuilder();

                foreach (char c in text)
                {
                    if (c >= 'А' && c <= 'Я')
                        result.Append((char)(c + 32));
                    else
                        result.Append(c);
                }

                File.WriteAllText(pathSaveFile, result.ToString());
                return pathSaveFile;
            }
        }
    }


