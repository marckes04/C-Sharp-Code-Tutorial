using System;

namespace Conditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert your age");
            int Age = int.Parse(Console.ReadLine());

            if (Age > 18)
            {
                Console.WriteLine("You are an adult");

                if(Age > 53)
                {
                    Console.WriteLine("You're old");
                }
            }

            else
            {
                Console.WriteLine("You're a child");

                if(Age == 4)
                {
                    Console.WriteLine("You are Baby");
                }

                if(Age >=14 && Age <= 17)
                {
                    Console.WriteLine("You're a teen");
                }

            }

        }
    }
}
