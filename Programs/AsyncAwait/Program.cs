using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

class WebServer
{
    static async Task  Main(string[] args)
    {
        //Stopwatch requestStopwatch = Stopwatch.StartNew();

        //Console.ForegroundColor = ConsoleColor.Green;

        //Console.WriteLine("Syncronous Method Start");

        //Console.WriteLine(FirstMethod() , SecondMethod(), LastMethod());

        //requestStopwatch.Stop();
        //Console.WriteLine($"Requests handled in {requestStopwatch.Elapsed.TotalSeconds} second.");

        Stopwatch requestStopwatch2 = Stopwatch.StartNew();
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Asyncronous Method start");
        Task task1 = Task.Run(() => { Console.WriteLine(FirstMethod()); });
        Task task2 = Task.Run(() => { Console.WriteLine(SecondMethod()); });
        Task task3 = Task.Run(() => { Console.WriteLine(LastMethod()); });
         Task.WaitAll(task1, task2, task3);
        Console.WriteLine($"Requests handled in {requestStopwatch2.Elapsed.TotalSeconds} second.");


        //Stopwatch requestStopwatch3 = Stopwatch.StartNew();
        //Console.ForegroundColor = ConsoleColor.Red;
        //Console.WriteLine("Asyncronous Method with async/await Stop");
        //await Task.Run(() => { Console.WriteLine(FirstMethod()); });
        //Task t2 = Task.Run(() => { Console.WriteLine(SecondMethod()); });
        // Task.Run(() => { Console.WriteLine(LastMethod()); });
        //Task.WaitAll(t2);
        //Console.WriteLine("Asyncronous Method async/await Stop");
        //Console.WriteLine($"Requests handled in {requestStopwatch3.Elapsed.TotalSeconds} second.");


        Console.ReadKey();
    }

    public  static string FirstMethod()
    {

        Console.WriteLine("Start First");
        Thread.Sleep(6000);
        Console.WriteLine("Stop First");
        return "I am first task";
    }
    public  static string SecondMethod()
    {
        Console.WriteLine("Start Second");

        Thread.Sleep(4000);

        Console.WriteLine("Stop Second");

        return "I am second task";
    }
    public  static string LastMethod()
    {
        Console.WriteLine("Start Third");
        Thread.Sleep(8000);
        Console.WriteLine("Stop Third");
        return "I am Last task";

    }
}
