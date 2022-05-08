using System;
using System.Collections.Generic;
using System.Text;

namespace Constructors
{
    class Student
    {
        public string Name;
        public string last_Name;
        public int id_number;
        public double final_GPA;

        public Student(string Name, string last_Name, int id_number, double final_GPA)
        {
            this.Name = Name;
            this.last_Name = last_Name;
            this.id_number = id_number;
            this.final_GPA = final_GPA;
        }

        public void Hello()
        {
            Console.WriteLine("Hello {0} {1}, your final GPA is: {2}", Name, last_Name, final_GPA);
        }

    }
}
