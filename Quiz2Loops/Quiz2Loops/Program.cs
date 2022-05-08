using System;

namespace Quiz2Loops
{
    class Program
    {

        static void Main(string[] args)
        {

            int Result = 0;
            for (int i = 1; i < 50; i++)
            {
                Result +=i;
            }
            Console.WriteLine("The final result of addition is: {0}", Result);
        }
    }
}
