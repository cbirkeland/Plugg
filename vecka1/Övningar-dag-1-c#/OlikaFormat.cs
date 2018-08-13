using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp37
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter fruit 1: ");
            string first = Console.ReadLine();

            Console.Write("Enter fruit 2: ");
            string second = Console.ReadLine();

            Console.Write("Enter fruit 3: ");
            string third = Console.ReadLine();




            var result = $"You entered three fruits: {first}, {second}, {third}!"; // interpolated

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("You entered three fruits: " + first + ", " + second + ", " + third + "!"); // Concatenation
            Console.WriteLine(result);

            string resultat2 = string.Format("{0}, {1}, {2}", first, second, third); // placeholders
            Console.WriteLine("You entered three fruits: " + resultat2 + "!");
        }
    }
}
