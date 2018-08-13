using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp43
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter names in a list (like Maria, Peter, Lisa): ");

            string names = Console.ReadLine();
            string[] nameList = names.Split(',');

            Console.WriteLine();

            foreach (string name in nameList)
            {
                Console.WriteLine($"{name} Andersson");
            }



            

            


        }
    }
}
