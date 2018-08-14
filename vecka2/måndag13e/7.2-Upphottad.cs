using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp33
{
    class Program
    {
       
            abstract class Shape
            {
                public string Name { get; set; }
                abstract public double CalculateArea();
            }

            class Circle : Shape
            {
                public double Radius { get; set; }

                public override double CalculateArea()
                {
                    return Radius * Radius * Math.PI;
                }
            }
        

            class Rectangle : Shape
            {
                public double Base { get; set; }
                public double Height { get; set; }

                public override double CalculateArea()
                {
                    double area = Base * Height;
                    return area;
                }
            }

            class Triangle : Shape
            {
                public double Top { get; set; }
                public double Base { get; set; }

                public override double CalculateArea()
                {
                    throw new NotImplementedException();
                }
            }



            static void Main(string[] args)
            {
                List<Shape> allShapes = new List<Shape>();



                bool meny = true;
                while (meny)
                {
                    Console.Write("Select (T)riangle, (R)ectangle, (C)ircle or (D)one: ");

                    string val = Console.ReadLine();
                    switch (val)
                    {
                        case "T":
                        case "t":

                            var triangle = AskForTriangle();
                            allShapes.Add(triangle);



                            break;

                        case "R":
                        case "r":

                            var rectangle = AskForRectangle();
                            allShapes.Add(rectangle);

                            break;


                        case "C":
                        case "c":
                            var circle = AskForCircle();
                            allShapes.Add(circle);


                            break;


                        case "D":
                        case "d":


                            PrintAllShapes(allShapes);
                            Console.WriteLine();



                            break;

                    }

                }


            }

            private static Circle AskForCircle()
            {
                var circle = new Circle();
                circle.Name = "circle";
                Console.Write("Enter radius of circle: ");
                circle.Radius = AskForNumber();
                return circle;


            }

            private static Triangle AskForTriangle()
            {
                var triangle = new Triangle();
                triangle.Name = "triangle";
                Console.Write("Enter top of triangle: ");
                triangle.Top = AskForNumber();
                Console.Write("Enter base of triangle: ");
                triangle.Base = AskForNumber();
                return triangle;

            }

            private static Rectangle AskForRectangle()
            {
                var rectangle = new Rectangle();
                rectangle.Name = "rectangle";
                Console.Write("Enter base of rectangle: ");
                rectangle.Base = AskForNumber();
                Console.Write("Enter height of rectangle: ");
                rectangle.Height = AskForNumber();
                return rectangle;

            }


            private static double AskForNumber()
            {
                double question = double.Parse(Console.ReadLine());
                return question;
            }

            private static void PrintAllShapes(List<Shape> allShapes)
            {
                foreach (var item in allShapes)
                {
                    Console.WriteLine($"I'm in a circle with radius=");
                }
            }
        }
    }

