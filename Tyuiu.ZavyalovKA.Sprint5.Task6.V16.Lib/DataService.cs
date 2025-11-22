using System.Text.RegularExpressions;
using System;

using System.IO;
using System.Linq;
using System.Reflection.Metadata;
using System.Text.RegularExpressions;
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

            MatchCollection matches = Regex.Matches(content, @"\b[a-zA-Z]+\b");
            return matches.Count;
        }
    }
}

