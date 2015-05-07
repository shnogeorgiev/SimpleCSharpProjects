using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Defining_Classes___04.S.U.L.S
{
    public class DropoutStudent : Student
    {
        private string dropoutReason;

        public DropoutStudent(string firstName, string lastName, int age, int number, double grade, string dropoutReason)
            : base(firstName, lastName, age, number, grade)
        {
            this.DropoutReason = dropoutReason;
        }

        public string DropoutReason { get; set; }

        public void ReApply()
        {
            throw new System.NotImplementedException();
        }

    }
}
