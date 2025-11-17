using tyuiu.cources.programming.interfaces;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.BukhryakovAY.Sprint5.Task7.V8.Lib
{
    public class DataService : ISprint5Task7V8
    {
        public string LoadDataAndSave(string path)
        {
            string readFromFile = File.ReadAllText(path);
            char[] charArray = readFromFile.ToCharArray();
            for (int i = 0; i < charArray.Length; i++)
            {
                if(charArray[i] >= 'А' && charArray[i] <= 'Я')
                {
                    charArray[i] = char.ToLower(charArray[i]);
                }
            }
            return new String(charArray);
        }
    }
}