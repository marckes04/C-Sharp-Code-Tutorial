using System;

namespace Quiz2Conditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            double price = 0;

            Console.WriteLine("Calaculate cost of a lawn for this season");
            Console.WriteLine("Please insert Length of loan");
            double length = double.Parse(Console.ReadLine());
            Console.WriteLine("Please insert width of loan");
            double width = double.Parse(Console.ReadLine());

            double Area = length * width;
            
            if(Area < 400)
            {
                price = 25 * 20;
                Console.WriteLine("Total price of lawn for this season is: {0}", price);
            }

            else if(Area >= 400 && Area <= 600)
            {
                price = 35 * 20;
                Console.WriteLine("Total price of lawn for this season is: {0}", price);
            }

            if (Area > 600)
            {
                price = 50 * 20;
                Console.WriteLine("Total price of lawn for this season is: {0}", price);
            }

        }
    }
}
