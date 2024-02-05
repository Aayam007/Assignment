using System;

// Abstract class
public abstract class Animal
{
    // Abstract method
    public abstract void MakeSound();

    // Regular method
    public void Sleep()
    {
        Console.WriteLine("Zzzz...");
    }
}

// Concrete class derived from the abstract class
public class Dog : Animal
{
    // Implementation of the abstract method
    public override void MakeSound()
    {
        Console.WriteLine("Woof! Woof!");
    }
    //public override void Sleep()
    //{
    //    Console.WriteLine("Woof! Woof!");
    //}
}

class Program
{
    static void Main()
    {
        // Creating an instance of the derived class (Dog)
        Dog myDog = new Dog();
       // Animal animal = new Animal();

        // Calling methods from both the abstract and concrete classes
        myDog.MakeSound();
        myDog.Sleep();
    }
}
