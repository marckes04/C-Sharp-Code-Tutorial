using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] grades = { 12, 34, 56, 45, 58, 79 };

            for(int i =0; i < grades.Length; i++)
                {
                grades[i] += 4;
                Console.WriteLine(grades[i]);
                }

            //foreach (int car in grades)
            //{
                
            //    Console.WriteLine(car);
            //}
        }
    }
}
