using System;

class Program
{
    static void Main()
    {
        bool MailayGareykoEntryThikXaTa = false;
        bool firstDivisionHo;

        do
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Mero First Division Aayo ho? Answer it using (true/false):");
            string input = Console.ReadLine();

            if (bool.TryParse(input, out firstDivisionHo))
            {
                MailayGareykoEntryThikXaTa = true;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Jepayo tai entry garchass 'true' or 'false' matra entry garvanay ko hoina  fheri entry gar");
                Console.ResetColor();
            }

        } while (!MailayGareykoEntryThikXaTa);

        if (firstDivisionHo)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Aba ma IT Padchu");
            Console.ReadKey();
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Ohh NO i didnot get first division so I will be the bus driver. so sad ");
            Console.ReadKey();
        }
    }
}