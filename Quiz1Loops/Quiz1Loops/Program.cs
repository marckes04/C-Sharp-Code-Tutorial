using System;

namespace Quiz1Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Payment System");
            Console.WriteLine("Please Insert rate payment for employee");
            double payment = double.Parse(Console.ReadLine());

            while (payment < 5.65 || payment > 49.95)
                    
            {
                Console.WriteLine("Inserted value is no valid, please insert payment rate again");
                payment = double.Parse(Console.ReadLine());
            }

            Console.WriteLine("This is your rate payment {0}", payment);

        }
    }
}
