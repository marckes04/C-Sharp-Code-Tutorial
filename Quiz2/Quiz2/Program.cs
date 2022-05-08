using System;

namespace Quiz2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Carpeting calculus rate: \n");
            Console.WriteLine("Insert Width: \n");
            int width = int.Parse(Console.ReadLine());
            Console.WriteLine("Insert Length: \n");
            int Length = int.Parse(Console.ReadLine());

            const int price = 200;

            int final = width * Length + price;

            Console.WriteLine("Your final result is: {0}", final);

        }
    }
}
