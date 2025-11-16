using tyuiu.cources.programming.interfaces;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.BukhryakovAY.Sprint5.Task2.V3.Lib
{
    public class DataService : ISprint5Task2V3
    {
        public string SaveToFileTextData(int[,] matrix)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask2.txt");
            for(int i = 0 ; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i,j] % 2 != 0)
                    {
                        matrix[i,j] = 0;
                    }
                    Console.Write(matrix[i, j] + ";");
                    File.AppendAllText(path, matrix[i,j].ToString() + ";");
                }
                File.AppendAllText(path,"\n");
                Console.WriteLine();
            }
            return path;
        }
    }
}
