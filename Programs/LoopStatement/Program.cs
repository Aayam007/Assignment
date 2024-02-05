using LoopStatement.DoWhile;
using System;

namespace LoopStatement
{
    public class Program
    {
        static void Main()
        {
            // Using ForEachLoop
            Console.WriteLine("=== ForEachLoop ===");
            ForEachLoop.ForEachLoopExample();
            Console.ReadKey();

            // Using ForLoop
            Console.WriteLine("\n=== ForLoop ===");
            ForLoop.ForLoopExample();
            Console.ReadKey();


            // Using DoWhile
            Console.WriteLine("\n=== DoWhile ===");
           DoWhileLoop.DoWhileExample();
            Console.ReadKey();


            // Using WhileLoop
            Console.WriteLine("\n=== WhileLoop ===");
            WhileLoop.WhileLoopExample();
            Console.ReadKey();

        }
    }
}
