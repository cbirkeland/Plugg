using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp50
{
    class Program
    {
        static void Main(string[] args)
        {

            string name = GetInputFromUser();
            string[] namelist = NameList(name);
            CleanUpArray(namelist);
            RespondToUser(namelist);
            LoudArray(namelist);

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

        // Clean Up Array

        static string[] CleanUpArray(string[] Namelist)
        {
            for (int i = 0; i < Namelist.Length; i++)
            {
                Namelist[i] = Namelist[i].Trim();
            }
            return Namelist;
        }

        static string[] LoudArray(string[] Namelist)
        {
            for (int i = 0; i < Namelist.Length; i++)
            {
                Namelist[i] = Namelist[i].Add("!!");
            }
            return Namelist;
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
