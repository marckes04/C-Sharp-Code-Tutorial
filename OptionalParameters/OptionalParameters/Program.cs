using System;

namespace OptionalParameters
{
    class Program
    {
        static void Main(string[] args)
        {
            Add(3, 4, 5);
            Add(3);
            Add(y:4);
            Add(5, 6);
            Add(5, z: 4);
            Add(y: 4, z: 2);
        }

        public static void Add (int x =3, int y = 2, int  z = 0)
        {
            double answer = x + y + z;
            Console.WriteLine("The answer is {0}", answer);
        }


    }
}
