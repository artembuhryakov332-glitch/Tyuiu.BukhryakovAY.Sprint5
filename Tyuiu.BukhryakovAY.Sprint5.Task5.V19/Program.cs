using Tyuiu.BukhryakovAY.Sprint5.Task5.V19.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       **");
        Console.WriteLine("***************************************************************************");
        string path = Path.Combine(Path.GetTempPath(), "InPutDataFileTask5V19.txt");
        Console.WriteLine("Путь:C:\\DataSprint5\\InPutDataFileTask5V19.txt");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Результат:                                                             **");
        Console.WriteLine("***************************************************************************");
        double result = ds.LoadFromDataFile(path);
        Console.WriteLine(result);
        Console.ReadKey();
    }
}