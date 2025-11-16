using Tyuiu.BukhryakovAY.Sprint5.Task2.V3.Lib;
namespace Tyuiu.BukhryakovAY.Sprint5.Task2.V3.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask2.txt");
            FileInfo fileState = new FileInfo(path);
            bool wait = fileState.Exists;
            Assert.AreEqual(true, wait);
        }
    }
}
