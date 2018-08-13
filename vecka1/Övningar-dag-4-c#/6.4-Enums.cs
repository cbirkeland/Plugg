using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp32
{
    class Program
    {
        enum FavoriteSport
        {
            Tennis, Rugby, Soccer, Hurling, Squash
        }

        enum FavoriteFood
        {
            Pasta, Soup, Grill, Fish
        }
            

        enum Gender
        {
            female, male, other
        }

        class Person
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public DateTime Birthday { get; set; }
            public string Gender { get; set; }
            public string FavoriteSport { get; set; }
            public string FavoriteFood { get; set; }

        }

        static void Main(string[] args)
        {
            var p = new Person
            {
                FirstName = "Lisa",
                LastName = "Andersson",
                Birthday = new DateTime(1985, 10, 17),
                Gender = "female",
                FavoriteSport = "tennis",
                FavoriteFood = "meat"


            };

            Console.WriteLine(p.FirstName + " is " + p.Gender);
            Console.WriteLine(p.FirstName + " like to play tennis");
            Console.WriteLine(p.FirstName + " dont like to play rugby");
            Console.WriteLine();
            // Här börjar listan för Sport enums
            Console.WriteLine("Here is a list of all Sport enums");
            string[] sports = Enum.GetNames(typeof(FavoriteSport));
            Array.Sort(sports);
            foreach (string s in sports)
            {
                
                Console.WriteLine("* " + s);
            }
            Console.WriteLine();

            // Här börjar listan för Food enums, sorterad
            Console.WriteLine("Here is a list of all Food enums");
            string[] food = Enum.GetNames(typeof(FavoriteFood));
            Array.Sort(food);
            foreach (string f in food)
            {
                Console.WriteLine("* " + f);
            }
            Console.WriteLine();
            Console.Write("Enter a sport: ");
            Console.ForegroundColor = ConsoleColor.Green;
            string input = Console.ReadLine();
            Console.ResetColor();

            if (Enum.TryParse(input, true, out FavoriteSport myenum))
            {
                Console.WriteLine("Oh, I know " + input);
            }
            else Console.WriteLine("Sorry I don't know " + input);
            
            

        }
    }




}


