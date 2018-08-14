using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {

        class Shape
        {
            public decimal RadiusOfShape { get; set; }
            public int MyProperty { get; set; }
        }

        class Circle : Shape
        {
            public int RadiusOfCircle { get; set; }


        }


        class Rectangle : Shape
        {

        }

        class Triangle : Shape
        {
            public int BaseOfTriangle { get; set; }
            public int HeightOfTriangle { get; set; }

        }

        class Square : Shape
        {


        }

        static void Main(string[] args)
        {
            List<Shape> allShapes = new List<Shape>();

            var shape = new Shape();
            var triangle = new Shape();
            var circle = new Shape();
            var rectangle = new Shape();


            bool meny = true;
            while (meny)
            {
                Console.Write("Select (T)riangle, (R)ectangle, (C)ircle or (D)one: ");

                string val = Console.ReadLine();
                switch (val)
                {
                    case "T":
                    case "t":

                        AskForTriangle();
                        allShapes.Add(triangle);


                        
                        break;

                    case "R":
                    case "r":

                        
                        allShapes.Add(rectangle);

                        break;


                    case "C":
                    case "c":
                        AskForCircle();
                        allShapes.Add(circle);
                        

                        break;


                    case "D":
                    case "d":

                        Console.WriteLine("I'm in a cirle with radius=" + "");
                        PrintAllShapes(allShapes);
                        Console.WriteLine();
                        meny = false;


                        break;

                }

            }


        }

        private static Circle AskForCircle()
        {
            var circle = new Circle();
            Console.Write("Enter radius of circle: ");
            int radius = Convert.ToInt32(Console.ReadLine());
            circle.RadiusOfCircle = (radius);
            

            return circle;


        }

        private static Triangle AskForTriangle()
        {
            var triangle = new Triangle();
            Console.Write("Enter base of triangle: ");
            int basen = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter height of triangle: ");
            int height = Convert.ToInt32(Console.ReadLine());
            triangle.BaseOfTriangle = (basen);
            triangle.HeightOfTriangle = (basen);
            return triangle;

        }

        private static Rectangle AskForRectangle()
        {
            var rectangle = new Rectangle();
            return rectangle;

        }

        private static void PrintAllShapes(List<Shape> allShapes)
        {
            foreach (var item in allShapes)
            {
                Console.WriteLine(item);
            }
        }


        



    }
}
