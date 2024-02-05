using System;
using System.Collections.Generic;
using System.Text;

namespace ClassAndObject.Cars
{
    public class Car
    {
        // Properties (attributes)
        public string Model;
        public string Color;
        public int Year;

        // Methods (behaviors)
        public void Start()
        {
            Console.WriteLine("Car is starting...");
        }

        public void Accelerate()
        {
            Console.WriteLine("Car is accelerating...");
        }

        public void Brake()
        {
            Console.WriteLine("Car is braking...");
        }
    }
}
