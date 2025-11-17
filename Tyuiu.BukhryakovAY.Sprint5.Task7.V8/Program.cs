using Tyuiu.BukhryakovAY.Sprint5.Task7.V8.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       **");
        Console.WriteLine("***************************************************************************");
        string path = Path.Combine(Path.GetTempPath(), "InPutDataFileTask7V8.txt");
        Console.WriteLine("Путь:C:\\DataSprint5\\InPutDataFileTask7V8.txt");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Результат :                                                             **");
        Console.WriteLine("***************************************************************************");
        string result = ds.LoadDataAndSave(path);
        Console.WriteLine(result);
        Console.ReadKey();
    }
}