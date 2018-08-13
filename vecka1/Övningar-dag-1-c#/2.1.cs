using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp33
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Console.Write("What is your name? ");
            string myName = Console.ReadLine();
            Console.Write("How old are you? ");
            int myAge = Convert.ToInt32(Console.ReadLine());
            Console.Write("Your favorite letter is: ");
            string myLetter = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("Thank you!");

            Console.WriteLine("");

            // Nu ska vi återge svaren
            Console.BackgroundColor = ConsoleColor.Black; Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("Your name is: " + myName);
            Console.WriteLine("You are " + myAge + " years old");
            Console.WriteLine("Your favorite letter is " + myLetter);

            Console.WriteLine();


            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("What is your favorite fruit? ");
            string myFruit = Console.ReadLine();
            Console.Write("What is your favorite car brand? ");
            string myCar = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Thank you!");

            Console.WriteLine();
            
            // Återger svaren igen

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Your favorite fruit is " + myFruit);
            Console.WriteLine("Your favorite car brand is " +myCar);

            Console.ForegroundColor = ConsoleColor.White;






        }
    }
}
