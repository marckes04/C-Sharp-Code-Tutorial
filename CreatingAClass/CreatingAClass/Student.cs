using System;
using System.Collections.Generic;
using System.Text;

namespace CreatingAClass
{
    class Student
    {

        public string Name;
        public string last_Name;
        public int id_number;
        public double final_GPA;

        public void Hello()
        {
            Console.WriteLine("Hello {0} {1}, your final GPA is: {2}", Name, last_Name, final_GPA);
        }

    }   
}
