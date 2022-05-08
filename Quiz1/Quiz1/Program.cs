using System;

namespace Quiz1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please insert two numbers \n");
            Console.WriteLine("Insert number 1: \n");
            int Num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Insert number 2: \n");
            int Num2 = int.Parse(Console.ReadLine());

            int Result = Num1 + Num2;

            Console.WriteLine("Your numbers are {0} {1} and result is: {2}", Num1, Num2, Result);


        }
    }
}
