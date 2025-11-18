// See https://aka.ms/new-console-template for more information
using System.IO;
using Tyuiu.ZavyalovKA.Sprint5.Task2.V16.Lib;
int[,] matrix = new int[3, 3] { {2, -4, -8},
                              {3, -7, -2},
                              {3, 8, 6} };
int rows = matrix.GetLength(0);
int columns = matrix.GetLength(1);
DataService ds = new DataService();
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("Массив: ");
for (int i =0; i < rows; i++)
{
    for(int j = 0; j < columns; j++)
    {
        Console.WriteLine($"{matrix[i, j]} \t ");
    }
}
Console.WriteLine();
Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");
string res = ds.SaveToFileTextData(matrix);
Console.WriteLine("Файл: " + res);
Console.WriteLine("Создан!");
Console.ReadKey();
