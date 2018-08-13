using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;    // Visual Studio krävde denna rad för att Regex skulle kunna aktiveras vid min bool
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            // Skulle vilja få SortedSet mer förklarat för mig. Efter många om och men fungerar det.
            // Men användaren får icke beställa samma produkt två gånger, vilket är ett problem.
            // Ska läsa på andra lösningar under veckan. Tiden rann ut för att bolla vidare.

            SortedSet<string> minLista = new SortedSet<string>();


            Console.WriteLine("Skriv in produkter. Avsluta med att skriva 'exit'");

            Console.Write("\n\n");

            string produkter;

            do
            {
                Console.Write("Ange produkt: ");
                produkter = Console.ReadLine();

                // Skapar här en bool som tar oss till "kassan"(metoden: tillKassan) ifall vi skriver exit dvs. true. 
                // Vid false lägger vi till produkter till Kassan. Försöker även baka in Regex vid false.

                bool result = tillKassan(produkter);
                
                // Får inte ordning på Regex här enligt instruktion annat än att man kräver stora bokstäver.

                if (result == false & (Regex.IsMatch(produkter, "^[A-ZÅÄÖ0-9]*$")))
                {
                    minLista.Add(produkter);
                }
                else
                {
                    Console.WriteLine(string.Format("Felaktigt format på din produkt, försök igen: ", produkter));
                }
                              


            } while (produkter.ToLower().Trim() != "exit");


            Console.Write("\n\n");


            Console.WriteLine("Du angav följande produkter (sorterade): ");
            minLista.ToList().ForEach(nyRad => Console.WriteLine("* " + nyRad));

        }

        // Här är kassan som vi går till om vi skriver exit eftersom bool då blir true.

        static bool tillKassan(string produkter)
        {
            if (produkter.ToLower().Trim() == "exit")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}