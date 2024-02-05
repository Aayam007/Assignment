using System;
using System.Collections.Generic;
using System.Text;

namespace LoopStatement.DoWhile
{
    public class DoWhileLoop
    {
        public static void DoWhileExample()
        {
            int count = 0;

            do
            {
                count++;
                Console.WriteLine("Count is: " + count);
            } while (count < 5);
        }
    }
}
