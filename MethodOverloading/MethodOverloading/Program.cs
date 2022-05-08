using System;

namespace MethodOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            Add(3, 4);
            Add("Mario", "Espitia");
            Add(5.6, 6.5);
        }

        public static void Add(int x, int y)
        {
            int Answer = x + y;
            Console.WriteLine(Answer);
        }

        public static void Add(string x, string y)
        {
            string Answer = x + " " +y;
            Console.WriteLine(Answer);
        }

        public static void Add(double x, double y)
        {
            double Answer = x + y;
            Console.WriteLine(Answer);
        }

    }
}
