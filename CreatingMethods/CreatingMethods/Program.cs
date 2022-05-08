using System;

namespace CreatingMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            //DisplayMessage();

            Console.WriteLine("Insert the Numbers of Adition");
            Console.WriteLine("Insert the first Number");
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine("Insert the second number");
            int y = int.Parse(Console.ReadLine());

            Addition(x, y);
        }

        //public static void DisplayMessage()
        //{
        //    Console.WriteLine("Hello World");
        //}

        public static int Addition(int N1, int N2)
        {
            int Result = N1 + N2;
            Console.WriteLine("The result of addition is: {0} ",Result);
            return Result;
        }
    }
}
