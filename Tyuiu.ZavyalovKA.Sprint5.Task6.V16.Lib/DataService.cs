using System;
using System.Linq;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.ZavyalovKA.Sprint5.Task6.V16.Lib
{
    public class DataService : ISprint5Task6V16
    {
        public int LoadFromDataFile(string path)
        {
            string content = File.ReadAllText(path);

            if (string.IsNullOrEmpty(content))
                return 0;

            string[] words = content.Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
            return words.Count(word => word.All(c => (c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z')));
        }
    }
}

