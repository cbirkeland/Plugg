using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp37
{
    class Program
    {
        class Produkt
        {
            

            public int ProduktID { get; set; }

        }



        class ElectronicBook : Produkt
        {
            public void SendBookTo(string emailAdress)
            {
                Console.WriteLine($"   Send book to {emailAdress}");
            }
        }

        class Book : Produkt
        {

            string _author;
            string isbn;
            string titel;


            public Book(string thisISBN, string thisTitel) 
            {
                isbn = thisISBN;
                titel = thisTitel;


            }


            public string Isbn { get; set; }

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
            var book = new Book("978-9-17-639279-9","Röda rummet");
            var ebook = new ElectronicBook();

            
            
            book.Isbn = "978-3-16-148410-0";
            book.Author ="Kalle";
            book.NrOfPages = (300);
            book.Size = book.Size;
            book.ProduktID = (1234);



            Console.WriteLine($"Info om boken:");


            Console.WriteLine();
            Console.WriteLine($"   ISBN:             {book.Isbn}");
            Console.WriteLine($"   Författare:       {book.Author}");
            Console.WriteLine($"   Antal sidor:      {book.NrOfPages}");
            Console.WriteLine($"   Vikt:             {book.Weight} gram");
            Console.WriteLine($"   Storlek:          {book.Size}");
            Console.WriteLine($"   Produktens id:    {book.ProduktID}");

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Olika test:");
             
            bool isbookBook = book is Book;
            Console.WriteLine("Är book en bok?         " + isbookBook);
            bool isbookEbook = book is ElectronicBook;
            Console.WriteLine("Är book en e-book?      " + isbookEbook);
            bool isbookProduct = book is Produkt;
            Console.WriteLine("Är book en produkt?     " + isbookProduct);

            Console.WriteLine();

            bool isebookABook = ebook is Book;
            Console.WriteLine("Är ebook en bok?        " + isebookABook);
            bool isebookAnEbook = ebook is ElectronicBook;
            Console.WriteLine("Är ebook en ebook?      " + isebookAnEbook);
            bool isebookAProdukt = ebook is Produkt;
            Console.WriteLine("är ebook en produkt?    " + isebookAProdukt);

            Console.WriteLine();
            ebook.SendBookTo("blablabla@gmail.com");




        }

    }
}
