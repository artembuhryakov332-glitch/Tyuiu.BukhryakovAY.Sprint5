using tyuiu.cources.programming.interfaces;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.BukhryakovAY.Sprint5.Task6.V22.Lib
{
    public class DataService : ISprint5Task6V22
    {
        public int LoadFromDataFile(string path)
        {
           string readerFromFile = File.ReadAllText(path);
           int count = readerFromFile.Split("мм").Length - 1;
           return count;
        }
    }
}
