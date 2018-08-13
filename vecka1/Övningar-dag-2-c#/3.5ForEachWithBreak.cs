using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp45
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter names in a list (like Maria, Peter, Lisa): ");

            string names = Console.ReadLine();
            string[] namnLista = names.Split(',');
            Console.WriteLine();

            foreach (string namn in namnLista)
            {
                Console.ForegroundColor = ConsoleColor.Green;


                if (namn.ToLower().Trim() == "zelda")
                {
                    
                    break;
                   
                }else
                Console.WriteLine($"{namn} Andersson");
            
            }
        }
    }
}
