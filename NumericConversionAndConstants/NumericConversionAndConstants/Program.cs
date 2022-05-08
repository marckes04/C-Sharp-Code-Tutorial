using System;

namespace NumericConversionAndConstants
{
    class Program
    {
        enum dayofweek
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        };

        static void Main(string[] args)
        {
            // Numeric conversion
            /*  int x = 5;

              double y = x;

              double mydouble = 5.5;
              int myInt = (int)mydouble;

              Console.WriteLine(myInt);

          */

            const int myConstInt = 5;
            Console.WriteLine(myConstInt);

            dayofweek day = dayofweek.Wednesday;
            Console.WriteLine(day);
            int numbertoday = (int)day;
            Console.WriteLine(numbertoday);
        }   
    }
}
