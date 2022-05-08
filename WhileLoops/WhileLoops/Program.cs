using System;

namespace WhileLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            int var = 0;
            //while(var < 7)
            //{
            //    Console.WriteLine("I love you Priscilla");
            //    var++;
            //}

            Console.WriteLine("Insert a number");
            int line1 = int.Parse(Console.ReadLine());

            while (line1 != -2)
            {
                var += line1;
                Console.WriteLine("To leave here press -2");
                Console.WriteLine("Insert a number");
                line1 = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Yor final result is: {0}", var);

        }
    }
}
