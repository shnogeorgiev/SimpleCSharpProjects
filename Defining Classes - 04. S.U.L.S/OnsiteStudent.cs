using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Defining_Classes___04.S.U.L.S
{
    public class OnsiteStudent : CurrentStudent
    {
        private int numberOfVisits;
        public OnsiteStudent(string firstName, string lastName, int age, int number, double grade, string currentCourse, int numberOfVisits)
             : base(firstName, lastName, age, number, grade, currentCourse)
        {
            this.NumberOfVisits = numberOfVisits;
        }

        public int NumberOfVisits { get; set; }
    }
}
