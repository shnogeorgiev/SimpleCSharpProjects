using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Defining_Classes___04.S.U.L.S
{
    public class Person
    {
        private string firstName;
        private string lastName;
        private int age;
        public Person(string firstName, string lastName, int age)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

    }
}
