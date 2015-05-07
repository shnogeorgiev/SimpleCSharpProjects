using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Defining_Classes___04.S.U.L.S
{
    public class Student : Person
    {
        private int number;
        private double grade;

        public Student(string firstName, string lastName, int age, int number, double grade)
            : base(firstName, lastName, age)
        {
            this.Number = number;
            this.Grade = grade;
        }

        public int Number { get; set; }
        public double Grade { get; set; }

    }
}
