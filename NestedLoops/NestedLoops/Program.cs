using System;

namespace NestedLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = 15;
            for(int j = 0; j < size; j++)
            {
                for(int i = 0; i < size; i++)
                {
                    Console.Write("{0,-2}", "<3");
                }
                Console.WriteLine();
            }
        }
    }
}
