
using System.IO;
using Tyuiu.BukhryakovAY.Sprint5.Task0.V14.Lib;
namespace Tyuiu.BukhryakovAY.Sprint5.Task0.V14.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\User\source\repos\Tyuiu.BukhryakovAY.Sprint5\Tyuiu.BukhryakovAY.Sprint5.Task0.V14\bin\Debug\net8.0\OutPutFileTask0.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool res = fileInfo.Exists;
            Assert.AreEqual(true, res);
        }
    }
}
