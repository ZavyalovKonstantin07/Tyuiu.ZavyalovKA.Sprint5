// See https://aka.ms/new-console-template for more information
using System.IO;
using Tyuiu.ZavyalovKA.Sprint5.Task4.V29.Lib;
DataService ds = new DataService();
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                         *");
Console.WriteLine("***************************************************************************");
string path = $@"{Directory.GetCurrentDirectory()}\InPutFileTask4.txt";
Console.WriteLine("Данные находятся в файле " + path);
Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");
double res = ds.LoadFromDataFile(path);
Console.WriteLine(res);
Console.ReadKey(); 

