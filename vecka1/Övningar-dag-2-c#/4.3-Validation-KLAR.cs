using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp53
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] peopleArray;   // Skapar Array direkt

            string separator = AskUserForSeparator();
            bool error = AskUserForErrorMessage();


            while (true) // När vi inte vet hur många gånger användaren kommer skriva fel. 
                         // While true betyder evig loop. 
            {

                string svar = GetInput();
                peopleArray = MinArray(svar, separator);  // Här används arrayen först och string svar ovan.
                CleanArray(peopleArray); // Efter MinArray går det till CleanArray. Hänvisa parameter till arrayen peopleArray.

                if (ValideraArray(peopleArray, error))
                {
                    break;
                }

            }
            SvaraUser(peopleArray);
        }

        private static string GetInput()
        {
            Console.Write("Skriv in namn: ");
            string name = Console.ReadLine();

            return name;
        }



        private static string[] MinArray(string svar, string separator)   // Här börjar Arrayen, glöm ej []
        {
            if (separator.Length == 0)
            {
                string[] list = svar.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                return list;
            }
            else
            {
                string[] list2 = svar.Split(new[] { separator }, StringSplitOptions.RemoveEmptyEntries);
                return list2;
            }





        }

        private static void SvaraUser(string[] peopleArray)
        {
            // Lägger till if-sats för om man inte skriver något namn alls
            if (peopleArray.Length == 0)
            {
                Console.WriteLine("Saknas namn i listan");
                return;
            }
            // Lägger till Foreach-sats. Där varje namn Trimmas och får ToUpper.

            foreach (string item in peopleArray)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"***SUPER-{item.ToUpper()}***");
            }
        }

        private static void CleanArray(string[] peopleArray)
        {
            for (int i = 0; i < peopleArray.Length; i++)    // Glöm ej .Length !!!!
            {
                peopleArray[i] = peopleArray[i].Trim();
            }
        }

        private static bool ValideraArray(string[] peopleArray, bool error)
        {

            if (peopleArray.Length == 0) // Ensam if-sats för om du inte skriva några bokstäver
            {
                if (error == true)
                {
                    Console.WriteLine("Du skrev inga bokstäver");
                }
                
                return false;
            }

            foreach (string item in peopleArray) // foreach-sats med if-sats med krav på antal bokstäver
            {

                if (item.Length <= 1 || item.Length >= 10)
                {
                    if (error == true)
                    {
                        Console.WriteLine("Namnet måste vara mellan 2-9 bokstäver");
                    }

                    return false;
                }
            }



            return true;


        }

        private static string AskUserForSeparator()
        {
            Console.Write("Which separator would you like to use?: ");
            string separator = (Console.ReadLine());
            return separator;
        }

        private static bool AskUserForErrorMessage()
        {
            Console.WriteLine("Do you want to see error messages?");
            string check = (Console.ReadLine());



            if (check == ("no"))
            {
                return false;
            }
            return true;

        }

        //private static bool AskForErrorMessage()
        //{
        //    Console.Write("Do you want to see error messages (default is yes)");






    }
}
