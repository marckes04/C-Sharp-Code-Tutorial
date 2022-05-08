using System;

namespace Quiz3Conditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randomGenerator = new Random();
            int RandomNumber = randomGenerator.Next(1, 11);

            Console.WriteLine("Advine the number from 1 to 10");
            int GuessNumber = int.Parse(Console.ReadLine());

            if(RandomNumber == GuessNumber)
            {
                Console.WriteLine("{0}, is the correct number", GuessNumber);
            }

            if (RandomNumber > GuessNumber)
            {
                Console.WriteLine("you were lower, the correct number is {0}", RandomNumber);
            }

            if (RandomNumber < GuessNumber)
            {
                Console.WriteLine("you were higher, the correct number is {0}", RandomNumber);
            }

        }
    }
}
