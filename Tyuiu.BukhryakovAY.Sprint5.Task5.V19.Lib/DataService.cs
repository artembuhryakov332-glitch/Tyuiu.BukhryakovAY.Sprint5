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
            string fileText = File.ReadAllText(path);
            string[] stringNumbers = fileText.Split(' ');
            List<int> singleDigitNumbers = new List<int>();

            foreach (string str in stringNumbers)
            {
                if (int.TryParse(str.Trim(), out int number))
                {
                    if (number >= -9 && number <= 9)
                    {
                        singleDigitNumbers.Add(number);
                    }
                }
            }

            if (singleDigitNumbers.Count == 0) return 0;

            int maxValue = singleDigitNumbers.Max();
            int minValue = singleDigitNumbers.Min();
            int result = maxValue - minValue;
            return result;
        }

    }
}
