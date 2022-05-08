using System;

namespace Quiz3Loops
{
    class Program
    {
        static void Main(string[] args)
        {

            Random randomGenerator = new Random();
            int randomNumber = randomGenerator.Next(1, 101);
            int usersGuess;
            int amountOfGuesses = 0;
            do
            {
                Console.WriteLine("Guess the random number");
                usersGuess = int.Parse(Console.ReadLine());
                if (usersGuess < randomNumber)
                {
                    Console.WriteLine("Your guess was too low");
                }
                else if (usersGuess > randomNumber)
                {
                    Console.WriteLine("Your guess was too high");
                }
                else
                {
                    Console.WriteLine("Your guess is correct");
                }
                amountOfGuesses++;

            } while (usersGuess != randomNumber);
            Console.WriteLine("You guessed {0} times", amountOfGuesses);
        }
    }
}
