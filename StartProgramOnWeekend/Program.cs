using System.Diagnostics;

namespace StartProgramOnWeekend;

class Program
{
    static void Main(string[] args)
    {
        if (args.Length == 0)
            Environment.Exit(1);
        
        
        string path = args[0];
        string[] arguments = args.Length > 1 ? args[1..] : Array.Empty<string>();
        
        if (DateTime.Now.DayOfWeek == DayOfWeek.Saturday || DateTime.Now.DayOfWeek == DayOfWeek.Sunday)
        {
            Process.Start(path, arguments);
        }
    }
}