using System;

namespace BoolData
{
    class Program
    {
        static void Main(string[] args)
        {
            //> >= 

            bool mybool = true;
            bool mybool2 = 5 > 6;

            Console.WriteLine(mybool2);

            int workedHours = 50;
            bool DoesEmployGetOverTime = workedHours > 40;

            Console.WriteLine("Does the employ Get Over? {0}", DoesEmployGetOverTime);
        }
    }
}
