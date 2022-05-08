using System;

namespace SearchingArray
{
    class Program
    {
        static void Main(string[] args)
        {
            // Checking exist value on my array

            string[] Girlfriends = { "Michelly", "Priscilla", "Charlotte", "Alejandra" };// Array's Object
            string[] Nationality = { "Brazil", "Brazil", "England", "Colombia" }; // Country Object

            Console.WriteLine("Insert girlfriend's name if this is avalible");
            string girl = Console.ReadLine();


            bool accepted = false;
            string NationalityGirlfriend;
            for(int i=0; i < Girlfriends.Length; i++)
            {
                if (girl == Girlfriends[i])
                {
                    accepted = true;
                    NationalityGirlfriend = Girlfriends[i];
                    //break; When this is false, this loop is broken
                }

                //Console.WriteLine("You married me"); final sentence
            }


            if (accepted == true)
            {
                Console.WriteLine("this girl has been Mario's girlfriend");
                Console.WriteLine("the nationality girlfriend is: {0}", Nationality);// Nationality position.
            }
            else
            {
                Console.WriteLine("this girl hasn't been Mario's girlfriend");
            }

        }
    }
}
