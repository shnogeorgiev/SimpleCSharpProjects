using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Defining_Classes___04.S.U.L.S
{
    public class SeniorTrainer : Trainer
    {
        public SeniorTrainer(string firstName, string lastName, int age)
            : base(firstName, lastName, age)
        {
        }

        public void DeleteCourse(string course)
        {
            Console.WriteLine("The course {0} has been deleted by {1} {2}", course, this.FirstName, this.LastName);
        }
    }
}
