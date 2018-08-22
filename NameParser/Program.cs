using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameParser
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your first name");
            var firstName = Console.ReadLine();

            foreach(var letter in firstName)
            {
                Console.WriteLine(letter);
            }

            Console.WriteLine("Enter your last name");
            var lastName = Console.ReadLine();
            var lastNameWithSpaces = "";

            foreach (var letter in lastName.ToUpper())
            {
                lastNameWithSpaces += letter + " ";
 
            }

            Console.WriteLine(lastNameWithSpaces.Trim());

            Console.WriteLine("Do you have a middle name? (y/n)");
            var hasMiddleName = Console.ReadLine();
            var middleName = "";

            if (hasMiddleName == "y")
            {
                Console.WriteLine("What is it?");
                middleName = Console.ReadLine();
                var i = 0;

                foreach(var letter in middleName)
                {
                    Console.WriteLine(letter.ToString().PadLeft(++i));
                }
            }
            else
            {
                Console.WriteLine($@"{firstName}, you are dumb and shouldnt have been born");
            }

            Console.WriteLine($"Goodbye {firstName} {middleName} {lastName}. Press enter to exit.");

            Console.ReadLine();
        }
    }
}
