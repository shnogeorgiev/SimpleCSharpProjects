using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Defining_Classes___04.S.U.L.S
{
    public class Trainer : Person
    {
        public Trainer(string firstName, string lastName, int age)
            : base(firstName, lastName, age)
        {
        }

        public void CreateCourse(string course)
        {
            Console.WriteLine("The course {0} has been created by {1} {2}", course, this.FirstName, this.LastName);
        }
    }
}
