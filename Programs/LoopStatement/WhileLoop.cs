using System;
using System.Collections.Generic;
using System.Text;

namespace LoopStatement
{
    public class WhileLoop
    {
        public static void WhileLoopExample()
        {
            int count = 0;

            while (count < 5)
            {
                count++;
                Console.WriteLine("Count is: " + count);
            }
        }
    }
}
