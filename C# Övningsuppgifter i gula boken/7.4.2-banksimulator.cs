using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp51
{
    class Program
    {
        static void Main(string[] args)
        {
            int saldo = 0;
            
            

            bool meny = true;
            while (meny)
            

            {
                Console.WriteLine("[I]nsättning");
                Console.WriteLine("[U]ttag");
                Console.WriteLine("[S]aldo");
                Console.WriteLine("[A]vsluta");

                string val = Console.ReadLine();

                switch (val)
                {

                    // Insättning
                    case "I":
                    case "i":
                        Console.WriteLine("Sätt in belopp: ");
                        saldo = saldo + Convert.ToInt32(Console.ReadLine());
                        

                    break;


                    // Uttag
                    case "U":
                    case "u":
                        Console.WriteLine("Belopp att ta ut: ");
                        saldo = saldo - Convert.ToInt32(Console.ReadLine());


                        break;

                    // Saldo
                    case "S":
                    case "s":
                        Console.WriteLine("Ditt belopp är: " + saldo);


                        break;


                    // Avsluta
                    case "A":
                    case "a":

                        Console.WriteLine("Programmet har nu avslutat");
                        meny = false;

                        break;





                }
              


            }


        }
    }
}
