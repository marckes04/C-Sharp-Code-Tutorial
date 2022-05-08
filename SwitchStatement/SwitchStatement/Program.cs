using System;

namespace SwitchStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is the restaurant menu");
            Console.WriteLine("Please choose the dish for today");
            Console.WriteLine("1. Bandeja Paisa");
            Console.WriteLine("2.Japanesse sushi");
            Console.WriteLine("3.Curry Wurst Deutsch");
            Console.WriteLine("4.Italian pizza");
            Console.WriteLine("5. American Burger");


            int option = int.Parse(Console.ReadLine());

            switch(option)
            {
                case 1:
                    Console.WriteLine("You selected Bandeja Paisa");
                    break;

                case 2:
                    Console.WriteLine("You selected Japanesse Sushi");
                    break;

                case 3:
                    Console.WriteLine("You selected Curry Wurst Deutsch");
                    break;

                case 4:
                    Console.WriteLine("You selected Curry Italian Pizza");
                    break;
                case 5:
                    Console.WriteLine("You selected American Burger");
                    break;

                default:
                    Console.WriteLine("Invalid Option");
                    break;
            }
        }
    }
}
