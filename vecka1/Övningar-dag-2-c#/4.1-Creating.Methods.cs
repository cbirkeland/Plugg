using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp48
{
    class Program
    {
        static void Main(string[] args)
        {

            string name = GetInputFromUser();
            string[] namelist = NameList(name);
            RespondToUser(namelist);

        }

        static string GetInputFromUser()
        {
            Console.Write("Enter names separated from comma (e.g Maria, Peter, Lisa) : ");
            string namn = Console.ReadLine();
            return namn;
        }

        static string[] NameList(string response)
        {
            string[] namelist = response.ToUpper().Split(',');
            return namelist;

        }

        static void RespondToUser(Array peopleArray)
        {
            foreach (string firstName in peopleArray)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"***SUPER-{firstName}***");
            }
        }

        



        




    }
}
