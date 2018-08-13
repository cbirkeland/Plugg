using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp22
{
    class Program
    {
        
            static void Main(string[] args)
            {
                double input;

                Console.Write("Skriv in ett flyttal så avrundar vi det till två decimaler: ");


                input = Convert.ToDouble(Console.ReadLine());

            Console.Write("\n\n");

            // Nu ska vi avrunda


            double avrunda = Math.Round(input,2);

                Console.WriteLine("Efter att vi avrundat till två decimaler blir det: " + avrunda);

            Console.Write("\n\n");

        }
        }

    }


