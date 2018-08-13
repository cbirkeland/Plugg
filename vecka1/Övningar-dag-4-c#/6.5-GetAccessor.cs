using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        class Adress
        {
            public string StreetName { get; set; }
            public string StreetNumber;
            public string City;
            public string ZipCode;
            public string FullAdress => StreetName + " " + StreetNumber;

            

        }

        static void Main(string[] args)
        {
            var adress = new Adress();
            adress.StreetName = "Långa gatan";
            adress.StreetNumber = "13B";
            adress.City = "Sundsvall";
            adress.ZipCode = "111 22";
            

            Console.WriteLine("Street           " + adress.StreetName);
            Console.WriteLine("Streetnumber     " + adress.StreetNumber);
            Console.WriteLine("City             " + adress.City);
            Console.WriteLine("ZipCode          " + adress.ZipCode);
            Console.WriteLine("FullAdress       " + adress.FullAdress);



        }
    }
}
