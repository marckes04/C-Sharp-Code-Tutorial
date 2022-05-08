using System;

namespace Quiz2Arrays
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Insert Amount of students:");
            int Amount = int.Parse(Console.ReadLine());

            String[] Name = new string[Amount];
            double[] Record = new double[Amount];

            double HighestRecord = 0;
            double AverageRecord = 0;
            string HighestName = " ";

            for (int i = 0; i < Amount; i++)
            {
                Console.WriteLine("Insert Name of Student");
                string Student = Console.ReadLine();
                Name[i] = Student;

                Console.WriteLine("Insert record of Student");
                double grade = double.Parse(Console.ReadLine());
                Record[i] = grade;

                AverageRecord += grade;
                if (grade > HighestRecord)
                {
                    HighestRecord = grade;
                    HighestName = Student;
                }
            }

            AverageRecord /= Amount;
            Console.WriteLine("The average record of students is: {0}", AverageRecord);
            Console.WriteLine("The student {0} has the highest score with: {1}", HighestName,HighestRecord);
        }
    }
}
