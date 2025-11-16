using Tyuiu.BukhryakovAY.Sprint5.Task3.V21.Lib;
namespace Tyuiu.BukhryakovAY.Sprint5.Task3.V21.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask3.bin");
            FileInfo fileState = new FileInfo(path);
            bool wait = fileState.Exists;
            Assert.AreEqual(true, wait);
        }
    }
}
