using System;

namespace ArrayMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Arr = { 12, 45, 67, 34, 56, 78 };
            Console.WriteLine("Check if this number exists");
            //int num = int.Parse(Console.ReadLine());

            //int answer = Array.BinarySearch(Arr, num);
            //if (answer < 0)
            //{
            //    Console.WriteLine("This Number doesn't exist on this array");
            //}
            //else
            //{
            //    Console.WriteLine("This number was found on the position: {0}", answer);
            //}

            // Sorting list

            //Array.Sort(Arr);

            //for(int i =0; i< Arr.Length; i++)
            //{
            //    Console.WriteLine(Arr[i]);

            //}

            // Reverse sorting 

            Array.Reverse(Arr);
            for(int i = 0; i< Arr.Length; i++)
            {
                Console.WriteLine(Arr[i]);
            }
        }
    }
}
