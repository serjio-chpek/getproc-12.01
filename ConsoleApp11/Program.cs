using System.Diagnostics;
internal class Program
{
    private static void Main(string[] args)
    {
        var process = Process.GetProcesses();
        var calc = process.FirstOrDefault(x => x.ProcessName == "CalculatorApp");
        foreach (var item in process)
        {
            Console.WriteLine($"{item.ProcessName}");
        }
        if (process.Any(x => x.ProcessName == "chrome"))
        {
            Console.WriteLine("на компе запущен хром");
        }

        if (calc != null)
        {
            calc.Kill();
        }
    }

    private static int GetMbytser(int bytes) => bytes / 1048576;
}