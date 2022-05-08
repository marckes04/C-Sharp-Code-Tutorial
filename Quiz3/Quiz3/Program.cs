using System;

namespace Quiz3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Time Conversion min to hours and remaining minutes");
            Console.WriteLine("Insert your time in minutes");
            float time = float.Parse(Console.ReadLine());
            float remain = time % 60;
            int FinalConversion = (int) time / 60;

            Console.WriteLine("Your conversion from minutes {0} has a final result is {1} converted in hours" +
                " and remaining time is {2}",time,FinalConversion,remain);
        }
    }
}
