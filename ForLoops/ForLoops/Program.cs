using System;

namespace ForLoops
{
    class Program
    {
        static void Main(string[] args)
        {

            //for(int i = 0; i<5;i++)
            //{
            //    Console.WriteLine("I love you Priscilla");
            //}

            Console.WriteLine("Insert a number of times to appear text");
            int times = int.Parse(Console.ReadLine());

            for(int i = 0; i< times; i++)
            {
                Console.WriteLine("I love you Priscilla");
            }


        }
    }
}
