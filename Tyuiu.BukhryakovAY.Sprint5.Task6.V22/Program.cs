using Tyuiu.BukhryakovAY.Sprint5.Task6.V22.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       **");
        Console.WriteLine("***************************************************************************");
        string path = Path.Combine(Path.GetTempPath(), "InPutDataFileTask6V22.txt");
        Console.WriteLine("Путь:C:\\DataSprint5\\InPutDataFileTask6V22.txt");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Результат:                                                             **");
        Console.WriteLine("***************************************************************************");
        double result = ds.LoadFromDataFile(path);
        Console.WriteLine(result);
        Console.ReadKey();
    }
}