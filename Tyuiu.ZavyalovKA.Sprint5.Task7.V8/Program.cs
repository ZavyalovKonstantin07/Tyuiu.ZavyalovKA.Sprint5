// See https://aka.ms/new-console-template for more information
using System.IO;
using Tyuiu.ZavyalovKA.Sprint5.Task7.V8.Lib;
DataService ds = new DataService();
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                         *");
Console.WriteLine("***************************************************************************");
string path = @"C:\Users\Завьялов Константин\source\repos\Tyuiu.ZavyalovKA.Sprint5\Tyuiu.ZavyalovKA.Sprint5.Task7.V8\bin\Debug\net8.0\InPutDataFileTask7V8.txt";
string pathSaveFile = @"C:\Users\Завьялов Константин\source\repos\Tyuiu.ZavyalovKA.Sprint5\Tyuiu.ZavyalovKA.Sprint5.Task7.V8\bin\Debug\net8.0\OutPutDataFileTask7V8.txt";
Console.WriteLine("Данные находятся в файле: " + path);
Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("Находится в файле: ");
pathSaveFile = ds.LoadDataAndSave(path);
Console.WriteLine(pathSaveFile);
Console.ReadKey();