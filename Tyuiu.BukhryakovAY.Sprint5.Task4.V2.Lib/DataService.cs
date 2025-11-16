using System.Globalization;
using tyuiu.cources.programming.interfaces;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.BukhryakovAY.Sprint5.Task4.V2.Lib
{
    public class DataService : ISprint5Task4V2
    {
        public double LoadFromDataFile(string path)
        {
           string fileInfo = File.ReadAllText(path);
           double x = Convert.ToDouble(fileInfo, CultureInfo.InvariantCulture);
           double result = ((Math.Cos(x) + 3 * x) / 0.25 * x) + 4 - 2.1 * x;
           return Math.Round(result,3);
        }
    }
}
