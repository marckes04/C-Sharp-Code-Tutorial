using System;

namespace Quiz3Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            sum(5);
            sum(4, 5, 7);
            int[] myArray = { 1,2, 3, 4, 5, 6, 7, 8, 9, 10 };
            sum(myArray);
        }

        public static void sum(params int[] myArray)
        {
            int sum = 0;
            for(int i =0; i< myArray.Length; i++)
            {
                sum += myArray[i];
            }

            Console.WriteLine("The result of adition is: {0}", sum);

        } 
    }
}
