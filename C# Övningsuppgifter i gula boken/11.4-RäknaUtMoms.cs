using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    class Program
    {
        static void Moms()
        {
            Console.WriteLine("Skriv ett belopp så lägger programmet på moms: ");
            double nr = Convert.ToInt32(Console.ReadLine());
            double moms = 1.25;
            
            double summa = (nr * moms);

            Console.WriteLine(summa);
        }

        static void Main(string[] args)
        {
            Moms();
        }
    }
}
