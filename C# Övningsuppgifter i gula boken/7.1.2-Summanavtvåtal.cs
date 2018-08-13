using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning_7._1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                int nr1, nr2, sum;
                Console.WriteLine("Skriv in två tal så beräknas jag summan");
                Console.Write("\n\n");

                Console.WriteLine("Skriv den första talet : ");
                nr1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Skriv det andra talet : ");
                nr2 = Convert.ToInt32(Console.ReadLine());
                sum = nr1 + nr2;

                Console.Write("\n\n");
                Console.WriteLine("Summan blir : " + sum);
                Console.Write("\n\n");
                Console.Write("Slut");
                Console.ReadLine();
            }

        }
    }
}
