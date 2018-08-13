using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp28
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.Write("Times to repeat: ");
            int amount = int.Parse(Console.ReadLine());

            Console.Write("Amount of rows: ");
            int rows = int.Parse(Console.ReadLine());
            Console.Write("Amount of columns: ");
            int columns = int.Parse(Console.ReadLine());


            for (int i = 0; i < amount; i++) // Yttersta for-loopen, hur många gånger den ska repetera
            {
                Console.WriteLine();
                Console.WriteLine();

                for (int height = 0; height < rows; height++) // antalet rader
                {
                    Console.WriteLine();

                    for (int width = 0; width < columns; width++) // antalet kolumner
                    {
                        
                        
                        Console.Write(name + "    "); 
                    }
                }
            }
            



        }
    }
}
