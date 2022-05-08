using System;

namespace DoWhileLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            string response;
            do
            {
                Console.WriteLine("Priscilla, Do you wanna marry me?");
                response = Console.ReadLine();
            }
            while (response == "No" || response == "no");

            if(response == "Yes" || response == "yes")
            {
                Console.WriteLine("Mario and Priscilla for ever <3");
            }

        }
    }
}
