using System;

namespace PassbyRef
{
    class Program
    {
        static void Main(string[] args)
        {
            int grade = 75;
            Console.WriteLine("The mark of student is: {0}" , grade);
            credits(grade);

            //Method with Array
            int[] grades = new int[1];
            grades[0] = 75;
            Console.WriteLine("The mark is : {0}", grades[0]);
            creditsArray(grades);
            Console.WriteLine("The final with extra credit result is: {0}", grades[0]);


        }

        public static void credits(int mark)
        {
            mark += 3;
            Console.WriteLine("The final with extra credit result is: {0}", mark);
        }


        public static void creditsArray(int[] grades)
        {
            grades[0] += 3;
        }

    }
}
