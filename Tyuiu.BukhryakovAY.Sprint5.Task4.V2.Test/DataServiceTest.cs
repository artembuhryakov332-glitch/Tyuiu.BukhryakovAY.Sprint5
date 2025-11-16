using Tyuiu.BukhryakovAY.Sprint5.Task4.V2.Lib;
namespace Tyuiu.BukhryakovAY.Sprint5.Task4.V2.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\DataSprint5\InPutDataFileTask4V2.txt";
            FileInfo fileState = new FileInfo(path);
            bool wait = fileState.Exists;
            Assert.AreEqual(true, wait);
        }
    }
}
