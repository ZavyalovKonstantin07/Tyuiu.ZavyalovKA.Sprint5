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
            string outputPath = path.Replace("InPut", "OutPut");
            string text = File.ReadAllText(path);

            char[] result = new char[text.Length];
            for (int i = 0; i < text.Length; i++)
            {
                char c = text[i];
                if (c >= 'А' && c <= 'Я')
                    result[i] = (char)(c + 32);
                else if (c == 'Ё')
                    result[i] = 'ё';
                else
                    result[i] = c;
            }

            File.WriteAllText(outputPath, new string(result));
            return outputPath;
        }
    }
}

