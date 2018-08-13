using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp40
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine();

            Console.Write("Times to repeat: ");
            int antal = Convert.ToInt32(Console.ReadLine());
            

            var result = $"Your name is: {name}";

            while (true)
            {
                if (antal != 0)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(result);
                    antal--;

                }
                else break;
                 
                
            }

        } 
    }
}
