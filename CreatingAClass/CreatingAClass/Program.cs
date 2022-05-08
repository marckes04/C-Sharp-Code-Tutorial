using System;

namespace CreatingAClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Student S1 = new Student();
            S1.Name = "Priscilla";
            S1.last_Name = "Aragao";
            S1.id_number = 01;
            S1.final_GPA = 100;
            S1.Hello();

            Student S2 = new Student();
            S2.Name = "Michelly";
            S2.last_Name = "Mary";
            S2.id_number = 02;
            S2.final_GPA = 94;
            S2.Hello();

            Student S3 = new Student();
            S3.Name = "Charlotte";
            S3.last_Name = "Mills";
            S3.id_number = 03;
            S3.final_GPA = 52;
            S3.Hello();

            Student S4 = new Student();
            S4.Name = "Julina";
            S4.last_Name = "Franka";
            S4.id_number = 04;
            S4.final_GPA = 65;
            S4.Hello();
        }
    }
}
