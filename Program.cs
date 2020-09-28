using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickCode
{
    class Program
    {

        static void Main(string[] args)
        {
            int userAge;

            userAge = displayGetUserAge();

        }

        static int displayGetUserAge()
        {
            int userAge;
            string userResponse;
            bool validResponse;

            do
            {
                validResponse = true;

                Console.Write("Enter Age");
                userResponse = Console.ReadLine();

                if (!int.TryParse(userResponse, out userAge))
                {
                    Console.WriteLine("Please enter a valid age.");
                    validResponse = false;
                }


            } while (!validResponse);
            return userAge;

        }
    }
}
