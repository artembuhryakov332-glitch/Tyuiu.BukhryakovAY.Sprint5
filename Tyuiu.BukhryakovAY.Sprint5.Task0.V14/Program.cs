using Tyuiu.BukhryakovAY.Sprint5.Task0.V14.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       **");
        Console.WriteLine("***************************************************************************");
        int x = 3;
        Console.WriteLine("x = " + x);
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Результат:                                                             **");
        Console.WriteLine("***************************************************************************");
        string res = ds.SaveToFileTextData(x);
        Console.WriteLine("Файл: " + res);
        Console.ReadKey();
    }
}