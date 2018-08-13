using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp27
{
    class Program
    {
        static void Main(string[] args)   // Göra fyrkanter / Squares
        {
            Console.Write("Ange kommando");
            string svar = Console.ReadLine();

            string[] firstArray = svar.Split('-');
            int[] realArray = Array.ConvertAll(firstArray, Convert.ToInt32);

            foreach (int item in realArray)
            {
                for (int height = 0; height < item; height++)
                {

                    for (int width = 0; width < item; ++width) // Ändra width++ till ++width
                    {
                        Console.Write("* ");  // Glöm en mellanslaget
                    }
                    Console.WriteLine();
                }


            }
        }
    }
}
