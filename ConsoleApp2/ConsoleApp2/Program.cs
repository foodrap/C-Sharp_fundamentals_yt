using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your first name?");
            string firstName = Console.ReadLine();
            Console.WriteLine("What is your last name?");
            string lastName = Console.ReadLine();

            string reversedFirstName = ReverseName(firstName);
            string reversedLastName = ReverseName(lastName);
            Console.WriteLine(String.Format("{0} {1}", reversedFirstName, reversedLastName));

        }
        private static string ReverseName(string name)
        {
            char[] messageArray = name.ToCharArray();
            Array.Reverse(messageArray);
            String.Concat(messageArray);
            return String.Concat(messageArray);
        }
    }
}
