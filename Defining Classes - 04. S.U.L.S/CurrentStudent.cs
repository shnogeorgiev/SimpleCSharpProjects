using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Defining_Classes___04.S.U.L.S
{
    public class CurrentStudent : Student
    {
        private string currentCourse;

        public CurrentStudent(string firstName, string lastName, int age, int number, double grade, string currentCourse)
            : base(firstName, lastName, age, number, grade)
        {
            this.CurrentCourse = currentCourse;
        }

        public string CurrentCourse { get; set; }
    }
}
