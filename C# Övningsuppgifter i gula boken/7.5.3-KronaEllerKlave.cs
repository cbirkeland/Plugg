using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Program
    {
        
        static void Main(string[] args)
        {   
            Console.WriteLine("Hur många gånger vill du chansa?");

            int antal = Convert.ToInt32(Console.ReadLine());
            Random slumpa = new Random();
            int result;

            for (int i = 0; i < antal; i++)
            {
                result = slumpa.Next(1, 3);

                if (result == 1)
                {
                    Console.WriteLine("[1] Krona");
                }
                else if (result == 2) Console.WriteLine("[2] Klave");

            }
        }
    }
}

