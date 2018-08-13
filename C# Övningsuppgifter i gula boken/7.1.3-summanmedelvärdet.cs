using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    class Program
    {
        static void Main(string[] args)
        {

            int nr1, nr2, nr3, sum, medel;
            Console.Write("Mata in 3 heltal så beräknar jag summan och medelvärdet");
            Console.Write("\n\n");
            Console.Write("Skriv in det första talet : ");
            nr1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Skriv in det andra talet : ");
            nr2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Skriv in det tredje talet : ");
            nr3 = Convert.ToInt32(Console.ReadLine());

            sum = nr1 + nr2 + nr3;



            Console.Write("\n\n");
            Console.WriteLine("Summan blir : " + sum);

            // Formeln för medelvärdet

            medel = sum / 3;


            Console.WriteLine("Medelvärdet blir : " + medel);

            Console.Write("\n\n");
            Console.Write("Slut");
            Console.ReadLine();
        }

    }
}

