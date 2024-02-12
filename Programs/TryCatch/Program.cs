using System;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            int result = Divide(10, 0);
            Console.WriteLine($"Result of division: {result}");
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("Error: Cannot divide by zero.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
        finally
        {
            Console.WriteLine("Finally block executed.");
        }

        Console.WriteLine("Program continues after try-catch-finally block.");
    }

    static int Divide(int numerator, int denominator)
    {
        if (denominator == 0)
        {
            // Manually throwing an exception
            throw new DivideByZeroException();
        }
        else
        {
            throw new Exception();
        }
        return numerator / denominator;
    }
}
