using System;
using System.Threading.Tasks;

class Program
{
    // Async Task1()
    public static async Task Task1()
    {
        Console.WriteLine("Start task1");
        await Task.Delay(2000);
        Console.WriteLine("End task1");
    }

    // Async Task2()
    public static async Task Task2()
    {
        Console.WriteLine("Start task2");
        await Task.Delay(1000);
        Console.WriteLine("End task2");
    }

    // Main to run asyncs
    public static async Task Main(string[] args)
    {
        var task1 = Task.Run(() => Task1());
        var task2 = Task.Run(() => Task2());

        await task1;
        await task2;
    }
}
