using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    class Program
    {
        class Program 
        
            // Får 


            static void Moms()
            {
                Console.WriteLine("Skriv ett belopp så lägger programmet på moms: ");
                double nr = Convert.ToInt32(Console.ReadLine());
                double moms = Convert.ToInt32(Console.ReadLine());

                double summa = (nr * moms);

                Console.WriteLine(summa);
            }

            static void Main(string[] args)
            {
                
                Moms();
            }
        }

    }
}
