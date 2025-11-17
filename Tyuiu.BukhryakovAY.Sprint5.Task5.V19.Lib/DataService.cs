using System;
using System.Globalization;
using System.Linq;
using tyuiu.cources.programming.interfaces;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.BukhryakovAY.Sprint5.Task5.V19.Lib
{
    public class DataService : ISprint5Task5V19
    {
        public double LoadFromDataFile(string path)
        {
            int maxValue = 0;
            int minValue = 0;
            int result = 0;
            string fileText = File.ReadAllText(path);
            string[] stringNumbers = fileText.Split(' ');
            int[] numbers = new int[stringNumbers.Length];

            for (int i = 0; i < stringNumbers.Length; i++)
            {
                double temp = double.Parse(stringNumbers[i].Trim(), CultureInfo.InvariantCulture);
                numbers[i] = (int)temp;
            }
             maxValue = numbers.Max();  
             minValue = numbers.Min();  
             result = maxValue - minValue;
             return result;
        }
       
    }
}
