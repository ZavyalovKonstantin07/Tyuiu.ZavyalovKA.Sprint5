using System.IO;
using Tyuiu.ZavyalovKA.Sprint5.Task5.V15.Lib;
namespace Tyuiu.ZavyalovKA.Sprint5.Task5.V15.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\Завьялов Константин\source\repos\Tyuiu.ZavyalovKA.Sprint5\Tyuiu.ZavyalovKA.Sprint5.Task5.V15\bin\Debug\net8.0\InPutDataFileTask5V15.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool FileExist = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, FileExist);
        }
    }
}
