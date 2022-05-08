using System;

namespace Quiz1Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert a Number to check multipliying Number: ");
            int Num = int.Parse(Console.ReadLine());
            multiply(Num);
        }

        public static void multiply(int x)
        {
            int N1 = x;

            for(int i = 1; i < 11 ; i++)
            {
                int Anwer = N1 * i;
                Console.WriteLine("{0} x {1} = {2}",i,N1,Anwer);
            }

        }

    }
}
