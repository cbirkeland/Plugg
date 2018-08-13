using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    class Program
    {

        static void HelloWorld()
        {
            Console.WriteLine("Skriv ett förnamn och efter efternamn, så lägger vi ihop dessa");
            string test1 = Console.ReadLine();
            string test2 = Console.ReadLine();

            Console.WriteLine(test1 + " " + test2);
        }


        static void Main(string[] args)
        {
            HelloWorld();
        }
    }
}
