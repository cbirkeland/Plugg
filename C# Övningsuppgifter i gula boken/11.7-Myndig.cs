using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp22
{
    class Program
    {

        static void Myndig()
        {
            Console.WriteLine("Skriv in din ålder: ");

            int svar = Convert.ToInt32(Console.ReadLine());

            bool myndig = true;

            


            if (svar > 18)
            {
                myndig = true;
                Console.WriteLine("Du är myndig!");
                
            }
            else
            {
                myndig = false;
                Console.WriteLine("Du är inte myndig");
                
            }

        }


        static void Main(string[] args)
        {
            Myndig();
        }
    }
}
