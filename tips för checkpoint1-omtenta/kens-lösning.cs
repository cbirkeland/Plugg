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
            Console.Write("Ange kommando: ");
            Console.ForegroundColor = ConsoleColor.Green;
            string input = Console.ReadLine();
            string[] readFrominput = input.Split('-');
            int[] numberlist = Array.ConvertAll(readFrominput, int.Parse);
            Console.ResetColor();

            //Går igenom listan
            foreach (int number in numberlist)
            {
                // En loop för hur många rader den ska skriva
                for (int Lines = 0; Lines <= number; Lines++)
                {
                    string star = "*";
                    Console.Write(star);
                    //En loop för hur många extra gånger den ska skriva per rad
                    for (int timesPerLine = 0; timesPerLine <= Lines; timesPerLine++)
                    {
                        Console.Write(star);
                    }
                    Console.WriteLine();

                }

            }
        }
    }
}
