using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        class Produkt
        {

        }
        class Animal
        {

        }

        class Cat : Animal    // : Hoppar in i Animal
        {
            public string FavoriteCatFood { get; set; }
            public int NrOfPawns { get; set; }
            public string Name { get; set; }
        }

        class Dog : Animal  // : Hoppar in i Animal
        {

            
            public string BarkLevel { get; set; }
        
        
        }

        static void Main(string[] args)
        {
            var a = new Animal();




        }
    }
}
