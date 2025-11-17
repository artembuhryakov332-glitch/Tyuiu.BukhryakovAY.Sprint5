using Tyuiu.BukhryakovAY.Sprint5.Task7.V8.Lib;
namespace Tyuiu.BukhryakovAY.Sprint5.Task7.V8.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\DataSprint5\InPutDataFileTask6V22.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool res = fileInfo.Exists;
            Assert.AreEqual(true, res);
        }
    }
}
