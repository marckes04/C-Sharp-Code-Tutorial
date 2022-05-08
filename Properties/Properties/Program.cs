using System;

namespace Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student("Tom", "Bob", 15, 75);
            s1.Name = "";
            Console.WriteLine(s1.Name);
            s1.FinalGrade = 105;
            Console.WriteLine(s1.FinalGrade);
            Console.WriteLine(s1.LastName);
        }
    }
}
