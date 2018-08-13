using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp27
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Är det fint väder? j/n");
            





            string weather = Console.ReadLine();


            // Det ska inte spela roll om man använder stor eller liten bokstav


            if (weather.ToUpper() == "J")
            {
                Console.WriteLine("Vi går på picknick!");
            }
            
            if (weather.ToLower() == "n")
            {
                Console.WriteLine("Vi stannar inne och läser en bok");
            }

            else
            {
                Console.WriteLine("Det var ett konstigt svar");
            }

        }
    }
}
