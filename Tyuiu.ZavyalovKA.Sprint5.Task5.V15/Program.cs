// See https://aka.ms/new-console-template for more information
using System.IO;
using Tyuiu.ZavyalovKA.Sprint5.Task5.V15.Lib;
DataService ds = new DataService();
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                         *");
Console.WriteLine("***************************************************************************");
string path = @"C:\Users\Завьялов Константин\source\repos\Tyuiu.ZavyalovKA.Sprint5\Tyuiu.ZavyalovKA.Sprint5.Task5.V15\bin\Debug\net8.0\InPutDataFileTask5V15.txt";
Console.WriteLine("Данные находятся в файле " + path);
Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");
double res = ds.LoadFromDataFile(path);
Console.WriteLine("Минимальное вещественное число в файле, которое делится на 5 = " + res);
Console.ReadKey();
