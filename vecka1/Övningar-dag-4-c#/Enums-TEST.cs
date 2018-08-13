using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp55
{
    class Program
    {
        enum CoffeeMachineColor
        {
            Red, Green, Black, White
        }
        class CoffeeMachine
        {
            public DateTime OrderedDate { get; set; }
            public decimal Price { get; set; }


        }
            

            
        

        static void Main(string[] args)
        {
            var k = new CoffeeMachine();
            k.OrderedDate = new DateTime(2018, 8, 10);
        }
    }
}
