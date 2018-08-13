using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp23
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Ange kommando: ");

            string input = Console.ReadLine();
            string[] firstArray = input.Split('-');
            int[] realArray = Array.ConvertAll(firstArray, int.Parse);

            Console.ResetColor();

            foreach (int num in realArray)
            {
                int i;
                int j;
                int k;

                for (i = 1; i <= num; i++)
                {
                    for (j = 1; j < num - i + 1; j++)
                    {
                        Console.Write(" ");
                    }
                    for (k = 1; k <= i; k++)
                    {
                        Console.Write(i);
                        Console.Write(" ");
                    }
                    Console.WriteLine();

                }
            }




        }
    }
}
