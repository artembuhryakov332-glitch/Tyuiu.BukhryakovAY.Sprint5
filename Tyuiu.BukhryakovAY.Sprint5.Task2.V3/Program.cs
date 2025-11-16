using Tyuiu.BukhryakovAY.Sprint5.Task2.V3.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       **");
        Console.WriteLine("***************************************************************************");
        int[,] matrix = new int[3,3];
        Console.WriteLine("Дана матрица размером 3x3:");
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix[i, j] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine();
        }
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Результат:                                                             **");
        Console.WriteLine("***************************************************************************");
        string result = ds.SaveToFileTextData(matrix);
        Console.WriteLine("Файл: " + result);
        Console.ReadKey();
    }
}