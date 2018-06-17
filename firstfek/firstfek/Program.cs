using System;

namespace somewhat
{
    class Program
    {
        static void Main(string[] arxgs)
        {
            bool f = true;
            while (f)
            {
                f = MainMenu();
            }
        }

        private static bool MainMenu()
        {
            Console.WriteLine("1.");
            Console.WriteLine("2.");
            string fuck = Console.ReadLine();
            if (fuck == "2")
            {
                Console.WriteLine("Nice!");
                return true;
            }
            else if (fuck == "2")
            {
                Console.WriteLine("Nice!");
                return true;
            }
            else
                Console.WriteLine("Nice!");
            {
                return true;
            }
        } 
    }
}