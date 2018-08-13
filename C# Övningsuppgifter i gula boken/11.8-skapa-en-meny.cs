using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp23
{
    class Program
    {
        static void Main(string[] args)
        {
            bool meny = true;
            while (meny)
            {
                Console.WriteLine("Välj ett alternativ genom att trycka respektive tangent:");
                Console.WriteLine("[K]ontrollera vädret [övning 7.3.3]");
                Console.WriteLine("[S]kriva ut en talföljd 1-20 [övning 7.5.1]");
                Console.WriteLine("[A]ddera() [övning 11.3]");
                Console.WriteLine("[Q]uit");

                Console.Write("\n\n");

                string val = Console.ReadLine();

                switch (val)
                {
                    case "K":
                    case "k":
                        Vädret();

                        break;

                    case "S":
                    case "s":
                        Talföljd();

                        break;

                    case "A":
                    case "a":
                        Addera();

                        break;

                    case "Q":
                    case "q":

                        Console.WriteLine("Programmet avslutas");

                        break;




                    default:
                        break;
                }
            }
        }


        static void Vädret()
        {
            Console.WriteLine("Är det fint väder? j/n");

            string weather = Console.ReadLine();


            // Det ska inte spela roll om man använder stor eller liten bokstav


            if (weather.ToUpper() == "J")
            {
                Console.WriteLine("Vi går på picknick!");
            }

            else if  (weather.ToLower() == "n")
            {
                Console.WriteLine("Vi stannar inne och läser en bok");
            }

            else
            {
                Console.WriteLine("Det var ett konstigt svar");
            }
            Console.Write("\n\n");

        }



        static void Talföljd()

        {
            int tal = 0;

            do
            {
                tal++;
                Console.WriteLine(tal);
            } while (tal < 20);

            Console.Write("\n\n");

        }




        static void Addera()

        {
            Console.WriteLine("Skriv det första talet");
            int tal1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Skriv det andra talet");
            int tal2 = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Summan blir: " + (tal1 + tal2));

            Console.Write("\n\n");
        }




    }
}
