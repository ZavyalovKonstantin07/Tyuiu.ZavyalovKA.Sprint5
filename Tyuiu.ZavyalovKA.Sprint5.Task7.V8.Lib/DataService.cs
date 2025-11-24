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
                // Создаем временный файл для результата
                string tempFile = Path.GetTempFileName();
                string pathSaveFile = Path.Combine(Path.GetDirectoryName(tempFile), "OutPutDataFileTask7V8.txt");

                // Удаляем временный файл и используем нужное имя
                File.Delete(tempFile);

                // Читаем и обрабатываем файл
                string text = File.ReadAllText(path, Encoding.UTF8);
                StringBuilder result = new StringBuilder();

                foreach (char c in text)
                {
                    if (c >= 'А' && c <= 'Я')
                        result.Append((char)(c + 32));
                    else if (c == 'Ё')
                        result.Append('ё');
                    else
                        result.Append(c);
                }

                File.WriteAllText(pathSaveFile, result.ToString(), Encoding.UTF8);
                return pathSaveFile;
            }
        }
    }


