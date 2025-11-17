using Tyuiu.BukhryakovAY.Sprint5.Task5.V19.Lib;
namespace Tyuiu.BukhryakovAY.Sprint5.Task5.V19.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\DataSprint5\InPutDataFileTask5V19.txt";
            FileInfo fileState = new FileInfo(path);
            bool wait = fileState.Exists;
            Assert.AreEqual(true, wait);
        }
    }
}
