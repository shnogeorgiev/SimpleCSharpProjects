using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Defining_Classes___04.S.U.L.S
{
    public class OnlineStudent : CurrentStudent
    {
        public OnlineStudent(string firstName, string lastName, int age, int number, double grade, string currentCourse)
            : base(firstName, lastName, age, number, grade, currentCourse)
        {
        }
    }
}
