using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp21
{
    class Program
    {
        static void ToPercentage()
        {
            double input;

            // Fungerar inte direkt som jag vill. Skriver man fler decimaler typ 0,5555555 blir det ej korrekt, endast två; 0,52 blir 52. 

            Console.Write("Skriv in ett flyttal med , så omvandlas det till heltal : ");


            input = Convert.ToDouble(Console.ReadLine());

            Console.Write("\n\n");

            


            double avrunda = (input * 100);

            Console.WriteLine("Efter att vi omvandlat blir det: " + avrunda);

            Console.Write("\n\n");

        }



        static void Main(string[] args)
        {
            ToPercentage();
        }


       
    }
}
