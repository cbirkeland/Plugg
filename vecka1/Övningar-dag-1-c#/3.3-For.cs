using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp41
{
    class Program
    {
        static void Main(string[] args)
        {
            ForLoop();

        }

        static void ForLoop()
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            Console.Write("Times to repeat: ");
            int antal = Convert.ToInt32(Console.ReadLine());


            


            for (int i = 0; i < antal; i++)
            {
                if (antal != 0)
                {
                    
                    Console.ForegroundColor = ConsoleColor.Green;
                    int[,] vektor = new int[,] { { 4, 4 } };
                    Console.WriteLine(name);
                }
                else break;
            } 


        
        }
    }
}
