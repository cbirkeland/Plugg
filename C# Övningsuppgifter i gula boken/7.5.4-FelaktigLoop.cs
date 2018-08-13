using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
            string str;
            do
            {
                Console.WriteLine("Vill du fortsätta loopen?");
                str = Console.ReadLine();
            } while (str == "j");  // Det var en felaktig operator( = ) 
        }
    }
}
