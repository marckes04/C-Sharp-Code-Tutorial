using System;

namespace Quiz2Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert a number to find its square and cube result: ");
            int Num = int.Parse(Console.ReadLine());
            Cube(Num);
        }

        public static void Cube(int x)
        {
            int R1 = x * x * x;
            Console.WriteLine("The result of cube is: {0}", R1);
            Square(x);
        }

        public static void Square(int y)
        {
            int R2 = y*y;
            Console.WriteLine("The result of square is: {0}", R2);

        }

    }
}
