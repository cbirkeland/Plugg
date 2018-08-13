using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20
{
    class Program
    {
        static void Main(string[] args)
        {

            {
                double input;

                Console.Write("Skriv in ett decimaltal så avrundar programmet det: ");


                input = Convert.ToDouble(Console.ReadLine());

                // Nu ska vi avrunda


                double avrunda = Math.Round(input);

                Console.WriteLine("Efter att vi avrundat decimalerna blir det: " + avrunda);

            }

        }
    }
}
