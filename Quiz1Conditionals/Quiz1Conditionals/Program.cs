using System;

namespace Quiz1Conditionals
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Write hourly per rate to this employee");
            double rate = double.Parse(Console.ReadLine());

            Console.WriteLine((rate < 7.5 || rate > 49.00) ? "incorrect value" : "rate payment has been processed");
            
        }
    }
}
