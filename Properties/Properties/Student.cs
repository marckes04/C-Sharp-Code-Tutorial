using System;
using System.Collections.Generic;
using System.Text;

namespace Properties
{
    class Student
    {
        
            private string name;
            private int age;
            private double finalGrade;
            //Auto-Implemented Property
            public string LastName { get; private set; }

            public Student(string name, string lastName, int age, double finalGrade)
            {
                this.name = name;
                this.LastName = lastName;
                this.age = age;
                this.finalGrade = finalGrade;
            }
            public Student(string name, string lastName, int age)
                : this(name, lastName, age, 0)
            {

            }

            public void SayHello()
            {
                Console.WriteLine("Hello from {0}", name);
            }
            public string Name
            {
                get
                {
                    if (age >= 18)
                    {
                        return name;
                    }
                    else
                    {
                        return "This student is too young";
                    }
                }
                set
                {
                    if (value != "")
                    {
                        name = value;
                    }
                }
            }
            public int Age
            {
                get
                {
                    if (age >= 18)
                    {
                        return age;
                    }
                    else
                    {
                        return -1;
                    }
                }
                set
                {
                    if (value != 0)
                    {
                        age = value;
                    }
                }
            }
            public double FinalGrade
            {
                get
                {
                    return finalGrade;
                }
                set
                {
                    if (value < 65)
                    {
                        value = 65;
                    }
                    else if (value > 100)
                    {
                        value = 100;
                    }
                    finalGrade = value;
                }
            }
    }

}
