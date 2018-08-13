using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    class Program
    {
      


       static void HelloWorld()
        {
            
            string test = Console.ReadLine();
            Console.WriteLine("Du skrev: " + test + " // Tack för att du skrev detta");
            

        }

        static void Main(string[] args)
        {
            Console.WriteLine("Skriv något: ");
            HelloWorld();
        }



    }
}
