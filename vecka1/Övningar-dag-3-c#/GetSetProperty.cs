using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var car1 = new Car("gul", 1300);
            var car2 = new Car("röd", 800);
            car1.WriteStuff();
        }

    }



    class Car
    {
        public string Color { get; set; }
        public int Weight { get; set; }

        public Car(string color, int weight)
        {
            Color = color;
            Weight = weight;
            //Console.WriteLine(Color + Weight);
        }

        public void   WriteStuff()
        {
            Console.WriteLine(Color + Weight);
        }
    }
}
