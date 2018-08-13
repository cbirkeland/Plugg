using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp28
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Hur många grader är det i Östersund? : ");
            int Östersund = Convert.ToInt32(Console.ReadLine());


            Console.Write("Hur många grader är det i Åmål? : ");
            int Åmål = Convert.ToInt32(Console.ReadLine());

            if (Åmål > Östersund)
            {
                Console.WriteLine("Det är kallare i Östersund");
            }
                
            if (Åmål < Östersund)
            {
                Console.WriteLine("Det är kallare i Åmål");
            }
                
            
            






        }
    }
}
