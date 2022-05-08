using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetAndSetMethods
{
    class Estudiante
    {
        private string name;
        private int age;
        private double finalGrade;

        public Estudiante(string name, int age, double finalGrade)
        {
            this.name = name;
            this.age = age;
            this.finalGrade = finalGrade;
        }

        public Estudiante(string name, int age)
            : this(name, age, 0)
        {

        }

        public string GetName()
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
        public void SetName(string newName)
        {
            if (newName != "")
            {
                name = newName;
            }
        }
        public int GetAge()
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
        public void SetAge(int newAge)
        {
            if (newAge != 0)
            {
                age = newAge;
            }
        }
        public double GetFinalGrade()
        {
            return finalGrade;
        }
        public void SetFinalGrade(double newFinalGrade)
        {
            if (newFinalGrade < 65)
            {
                newFinalGrade = 65;
            }
            else if (newFinalGrade > 100)
            {
                newFinalGrade = 100;
            }
            finalGrade = newFinalGrade;
        }
    }
}
