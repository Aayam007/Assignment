using ClassAndObject.Cars;


namespace ClassAndObject
{
    class Program
    {
        static void Main()
        {
            // Creating an object (instance) of the Car class
            Car myCar = new Car();

            // Accessing and setting properties
            myCar.Model = "Toyota";
            myCar.Color = "Blue";
            myCar.Year = 2022;

            // Calling methods
            myCar.Start();
            myCar.Accelerate();
            myCar.Brake();
        }
    }
}
