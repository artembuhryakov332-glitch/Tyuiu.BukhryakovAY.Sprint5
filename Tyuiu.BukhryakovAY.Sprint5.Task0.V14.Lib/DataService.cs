using tyuiu.cources.programming.interfaces;
using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
namespace Tyuiu.BukhryakovAY.Sprint5.Task0.V14.Lib
{
    public class DataService : ISprint5Task0V14
    {
        public string SaveToFileTextData(int x)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask0.txt");
            int value = 3;
            double y = 4 * Math.Pow(value,3) / (Math.Pow(value,3) - 1);
            double result = Math.Round(y, 3);
            File.WriteAllText(path,result.ToString());
            return path;    
        }
    }
}
