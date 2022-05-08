using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int myint;
            double mydouble = 5.5;
            myint = 5;
            String mystring = "Hello World";
            char mychar = 'A';
          

            Console.WriteLine(myint);
            Console.WriteLine(mydouble);
            Console.WriteLine(mystring);
            Console.WriteLine(mychar);

            Console.WriteLine("The value of myInt is {0} and the value of myDouble is {1}", myint,mydouble);
        }
    }
}
