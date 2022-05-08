using System;

namespace aritmeticOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            // + - * / %
            int myInt = 5 + 5;
            Console.WriteLine(myInt);
            int myInt2 = 5 - 5;
            Console.WriteLine(myInt2);
            int myInt3 = 5 * 5;
            Console.WriteLine(myInt3);
            int myInt4 = 5 / 5;
            Console.WriteLine(myInt4);

            double mydouble = 45.0 / 2;
            Console.WriteLine(mydouble);

            double remain = 5 % 4;
            Console.WriteLine(remain);

            int result = 5 * 4 + 3;
            Console.WriteLine("the result is {0} ", result);

            int MyInt5 = myInt + myInt2 + myInt3 + myInt4;
            Console.WriteLine("Final result is {0}", MyInt5);


            int x = 5;
            x = x + 1;
           // x *= 5;

            Console.WriteLine("The value of x variable is {0}", x);
            int y = 9;

            y++;
            Console.WriteLine("The value of y variable is {0}", y);

            int b = 4;
            int c = b++;
            Console.WriteLine("The value of b variable is {0} and value of c variables is {1}", b, c);
        }
    }
}
