using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp21
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Console.ForegroundColor = ConsoleColor.Green;
                string name1;
                string name2;

                Console.Write("Skriv ett namn på en person: ");
                name1 = Console.ReadLine();


                Console.Write("\n\n");
                Console.Write("Skriv ett namn på en till person: ");
                name2 = Console.ReadLine();

                Console.WriteLine("Du har nu valt att döpa dina karaktärer till " + name1 + " och " + name2);
                Console.Write("Både " + name1 + " och " + name2 + " kommer du att kunna styra i tråkig 2d-miljö och utföra väldigt enformiga uppdrag med.");

                Console.Write("\n\n");

            }

        }
    }
}
