using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    class Program
    {

        static void Addera()
        {
            int tal1 = Convert.ToInt32(Console.ReadLine());
            int tal2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(tal1 + tal2);
        }


        static void Main(string[] args)
        {
            Addera();

        }
    }
}
