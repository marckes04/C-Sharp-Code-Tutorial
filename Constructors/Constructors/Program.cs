using System;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Student S1 = new Student("Priscilla","Aragao",01,100);
            S1.Hello();

            Student S2 = new Student("Michelly", "Mary", 02, 94);
            S2.Hello();

            Student S3 = new Student("Charlotte", "Mills", 03,52);
            S3.Hello();

            Student S4 = new Student("Julina", "Franka",04,65);
            S4.Hello();
        }
    }
}
