// See https://aka.ms/new-console-template for more information
using System.IO;
using Tyuiu.ZavyalovKA.Sprint5.Task6.V16.Lib;
DataService ds = new DataService();
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                         *");
Console.WriteLine("***************************************************************************");

string path = @"C:\Users\Завьялов Константин\source\repos\Tyuiu.ZavyalovKA.Sprint5\Tyuiu.ZavyalovKA.Sprint5.Task6.V16\bin\Debug\net8.0\InPutDataFileTask6V16.txt";
Console.WriteLine("Данные находятся в файле " + path);
Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");
int res = ds.LoadFromDataFile(path);
Console.WriteLine(res);
Console.ReadKey();
