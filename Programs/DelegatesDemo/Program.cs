using System;

    // Define a delegate
public delegate void Operation();
class Program
{

    static void Main(string[] args)
    {
        //Instantiation
        Operation operation = new Operation(MyFunc);
        Operation operation2 = new Operation(MyFunc2);
        operation(); //Invocation
        operation2();   
        
    }

    // Method that takes a delegate as parameter
    public static void MyFunc()
    {
        Console.WriteLine("I was Called  by Delegates. my name is MyFunc");
    }

    public static void MyFunc2()
    {
        Console.WriteLine("I was Called  by Delegates. My name is My function 2");
    }
}
