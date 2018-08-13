 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] NameList;

            Console.WriteLine("Ange kommando: ");
            string response = Console.ReadLine();
            NameList = NameArray(response);


            foreach (var item in NameList)
            {
                int tal = int.Parse(item);
                int rows = 1;
                for (int j = 0; j < tal; j++)
                {

                    Console.WriteLine();
                    for (int i = 0; i < rows; i++)
                    {

                        Console.Write("*");
                    }
                    rows++;
                    Console.WriteLine();
                }
            }

        }

        static string[] NameArray(string response)
        {
            string[] list = response.Split(new[] { "-" }, StringSplitOptions.RemoveEmptyEntries);
            return list;
        }
    }
}

