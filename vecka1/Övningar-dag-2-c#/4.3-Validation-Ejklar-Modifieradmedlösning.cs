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
            PeopleArrayIsValid(namelist);
            CleanUpArray(namelist);
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

        // Clean Up Array

        static string[] CleanUpArray(string[] Namelist)
        {
            for (int i = 0; i < Namelist.Length; i++)
            {
                Namelist[i] = Namelist[i].Trim();
            }
            return Namelist;
        }

        private static bool PeopleArrayIsValid(string[] peopleArray)
        {
            if (peopleArray.Length == 0)
            {
                Console.WriteLine("The list does not contain any names");
                
                return true;
            }
            foreach (string item in peopleArray)
            {
                if (item.Length <= 1 || item.Length >= 10)
                {
                    Console.WriteLine("A person can only have 2-9 characters");
                    
                    return true;



                }
            }
            return true;

            
            
            
     
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
