// See https://aka.ms/new-console-template for more information
using System.IO;
using Tyuiu.ZavyalovKA.Sprint5.Task3.V11.Lib;
int x = 3;
DataService ds = new DataService();
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("x: " + x);
Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");
string res = ds.SaveToFileTextData(x);
Console.WriteLine("Файл: " + res);
Console.WriteLine("Создан!");
Console.ReadKey();
