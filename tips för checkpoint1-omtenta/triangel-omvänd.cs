using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp24
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ange kommando: ");
            Console.ForegroundColor = ConsoleColor.Green;
            string numbers = Console.ReadLine();
            string[] firstArray = numbers.Split('-');
            Console.ResetColor();

            int[] realArray = Array.ConvertAll(firstArray, int.Parse);

            foreach (int number in realArray)
            {
                for (int height = number; height >= 1; height--)  // ändra till height = number i början, då börjar den på värdet, ändra till >= 1 och ta height--
                {
                    Console.WriteLine("");

                    for (int width = height; width >= 1 ; width--)  // ändra width = number, width >= 1, så att den slutar på 1; glöm en width-- så att den minskar
                    {
                        Console.Write("*");
                    }

                }

            }
        }
    }
}
