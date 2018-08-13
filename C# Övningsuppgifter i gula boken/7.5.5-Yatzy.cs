using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {
            // PROGRAMMET SKA KÖRAS 6 GÅNGER I EN FOR-LOOP
            // LOOPEN SKA SLUMPA 6 ST NUMMER.

            Console.WriteLine("Nu spelar vi Yatzy!");
            Console.WriteLine("Tärningen rullar.....");
            
            int result;
            Random slumpa = new Random();
            

            for (int i = 0; i < 6; i++)
            {
                result = slumpa.Next(1, 7);
                Console.WriteLine(result);
                    
            }
        }
    }
}
