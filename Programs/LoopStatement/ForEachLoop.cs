using System;
using System.Collections.Generic;
using System.Text;

namespace LoopStatement
{
    public class ForEachLoop
    {
        public static void ForEachLoopExample()
        {
            int[] numbers = { 1, 2, 3, 4, 5 };

            foreach (var number in numbers)
            {
                Console.WriteLine("Number is: " + number);
            }
        }
    }
}
