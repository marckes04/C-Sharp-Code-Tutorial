using System;

namespace Quiz_1Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ZIP code company");
            string[] codes = {"12334","3344","123456","1995","123455","543009","456789","3456",
            "2000", "34450"};

            Console.WriteLine("Insert the ZIP code to check");
            string zip = Console.ReadLine();

            bool found = false; 
            
            for(int i =0; i < codes.Length; i++)
            {
                if(codes[i] == zip)
                {
                    found = true;
                    break;
                }
            }

            if(found == true)
            {
                Console.WriteLine("ZIP code has been found");
            }
            else
            {
                Console.WriteLine("Zip code is not in this company");
            }
        }
    }
}
