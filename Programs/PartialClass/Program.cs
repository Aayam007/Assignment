using System;

namespace PartialClass
{
    class Program
    {
        static void Main()
        {
            // Creating an instance of the partial class
            MyClass myInstance = new MyClass();

            // Calling methods from both parts of the partial class
            myInstance.Method1();
            myInstance.Method2();
        }
    }
}
