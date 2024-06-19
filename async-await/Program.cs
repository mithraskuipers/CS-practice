using System;
using System.Threading.Tasks;

class Program
{
    // Async task1()
    public static async Task Task1()
    {
        Console.WriteLine("Start task1");
        await Task.Delay(2000);
        Console.WriteLine("End task1");
    }

    // Async task2()
    public static async Task Task2()
    {
        Console.WriteLine("Start task2");
        await Task.Delay(1000);
        Console.WriteLine("End task2");
    }

    // Main to run asyncs
    public static async Task Main(string[] args)
    {
        await Task.WhenAll(Task1(), Task2());
    }
}
