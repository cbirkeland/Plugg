using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp54
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int tal = Convert.ToInt32(Console.ReadLine());
            

            do
            {
                
                
                if (tal < 0 | tal > 100)
                {
                    Console.WriteLine("Felaktig siffra, avslutar programmet");

                    break;  
                }
                else

                    tal++;
                Console.WriteLine(tal);

            } while (tal < 100);


        }
    }
}
