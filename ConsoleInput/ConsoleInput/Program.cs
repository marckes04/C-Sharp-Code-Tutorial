using System;

namespace ConsoleInput
{
    class Program
    {
        static void Main(string[] args)
        {
            /*   Console.WriteLine("What is your name?");
               string name = Console.ReadLine();
               Console.WriteLine("What is your lastname?");
               string lastname = Console.ReadLine();

               Console.WriteLine("hello mr/mrs {0} {1}", name, lastname);
            */

            Console.WriteLine("Enter a number");
            int number = int.Parse(Console.ReadLine());
            number = number + 10;

            Console.WriteLine("Your final number is {0}", number);

        }
    }
}
