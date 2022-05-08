using System;

namespace Quiz3Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Girlfriends = { "Michelly", "Priscilla", "Charlotte", "Janiele", "Xiomy", "Alejandra","Nina"};// possible words to find
            Random random = new Random();//Random Library
            int randomIndex = random.Next(0, 7);// Random Spaces between 0-7
            string SelectedWord = Girlfriends[randomIndex]; //Words assigned in array spaces
            string HiddenWord = "";// Hidden Words blank space

            for(int i = 0; i < SelectedWord.Length; i++)// For loop applied in hidden words spaces according to random word 
            {
                HiddenWord += "*"; // Hidden words Spaces assigned with * symbol 
            }
            //Guessing stuff
            while (HiddenWord.Contains("*")) // while the right letter is not found, it will be represented by * 
            {
                Console.WriteLine("Word: {0}", HiddenWord);
                Console.Write("Guess a letter >> "); //  This system will prompt to  user for a new letter again.
                char letter = char.Parse(Console.ReadLine());// Input for a new char.
                bool containsLetter = false; // New Variable to evaluate if the right char has been found.
                for (int i = 0; i < SelectedWord.Length; i++) // This cycle allows to check the selected word 
                {
                    if (SelectedWord[i] == letter) //Conditional to review the char in the right position
                    {
                        HiddenWord = HiddenWord.Remove(i, 1); //  when the char is found, * symbol is removed in my array
                        HiddenWord = HiddenWord.Insert(i, letter.ToString());// This codeline is used to insert new char, when * is replaced
                        containsLetter = true; // This bool variable is changed on this value as true. 
                    }
                }
                if (containsLetter == true) // If the letter is found
                {
                    Console.ForegroundColor = ConsoleColor.Green;// Show green 
                    Console.WriteLine("Yes! {0} is in the word", letter);
                } 
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Sorry, {0} is not in the word", letter); // When it not found
                }
                Console.ResetColor(); // Line to reset color
            }

            Console.WriteLine("Congrtulations The word {0} has been found, She will be the Mario's Girlfriend", SelectedWord);
        }
    }
}
