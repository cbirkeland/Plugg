using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp47
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in ett nummer: ");
            int nr = int.Parse(Console.ReadLine());

            string classify = (nr == 20) ? "Equal to 20" : (nr == 0) ? "Number is zero" : (nr >= 20) ? "Equal or higher than 20" : "Equal or lower than 20";
            Console.WriteLine(classify);
            
        }
    }
}
