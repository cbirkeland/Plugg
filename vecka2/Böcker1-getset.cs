using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp34
{
    class Program
    {
        class Book
        {
            public string ISBN { get; set; }

            public string Author { get; set; }

            int pages;
            public int NrOfPages
            {

                get
                {
                    return pages;
                }
                set
                {
                    if ((value > 0) && (value < 1000))
                    {
                        pages = value;
                    }
                    else pages = 300;
                }
            }

            public double Weight
            {
                get
                {
                    return pages * 0.8;
                }

            }
            string size;
            public string Size
            {
                get
                {
                    return size;
                }

                set
                {
                    if (pages <= 100)
                    {
                        size = "Tunn";
                    }
                    if (pages > 300)
                    {
                        size = "Tjock";
                    }
                    else
                    {
                        size = "Normal";
                    }
                }
            }

        }

        static void Main(string[] args)
        {
            var book = new Book();

            book.ISBN = "978-3-16-148410-0";
            book.Author = "Kalle";
            book.NrOfPages = (60);
            book.Size = book.Size;
            
            Console.WriteLine($"Info om boken:");
            

            Console.WriteLine();
            Console.WriteLine($"   ISBN:        {book.ISBN}");
            Console.WriteLine($"   Författare:  {book.Author}");
            Console.WriteLine($"   Antal sidor: {book.NrOfPages}");
            Console.WriteLine($"   Vikt:        {book.Weight} gram");
            Console.WriteLine($"   Storlek:     {book.Size}");

            Console.WriteLine();

        }


        
        
    }
}
