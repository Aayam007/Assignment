using System;

// Sealed class
//A class that cannot be inherited. It is marked with the sealed keyword.
//Useful when you want to prevent further extension of the class.
sealed class MySealedClass
{
    private string message;

    public MySealedClass(string msg)
    {
        message = msg;
    }

    public void DisplayMessage()
    {
        Console.WriteLine($"Message from sealed class: {message}");
    }
}

// This will generate a compilation error since you cannot inherit from a sealed class
//class AnotherClass : MySealedClass {}

//public class Test : MySealedClass

class Program
{
    static void Main()
    {
        // Create an instance of the sealed class
        MySealedClass sealedInstance = new MySealedClass("Hello, I am a sealed class!");

        // Call a method on the sealed class
        sealedInstance.DisplayMessage();

        // Uncommenting the line below will result in a compilation error
       //  AnotherClass anotherInstance = new AnotherClass();
    }
}
