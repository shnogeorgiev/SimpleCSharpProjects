using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Defining_Classes___01.Persons
{
    class Program
    {
        static void Main(string[] args)
        {
            Person personOne = new Person("Peter Georgiev", 17);
            Person personTwo = new Person("Peter Georgiev" , 17, "sargar@abv.bg");

            Console.WriteLine(personOne);
            Console.WriteLine(personTwo);
        }
    }
    class Person
    {
        private string name;
        private int age;
        private string email;

        public Person(string name, int age, string email)
        {
            this.Name = name;
            this.Age = age;
            this.Email = email;
        }
        public Person(string name, int age):this(name, age, null)
        {
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value)) throw new Exception("Your name is invalid!");
                this.name = value;
            }
        }
        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                if (value < 1 || value > 100) throw new ArgumentException("Your age is invalid");
                this.age = value;
            }
        }
        public string Email
        {
            get
            {
                return this.email;
            }
            set
            {
                if (value != null && (value.Length == 0 || !value.Contains("@")))
                    throw new Exception("Your email is invalid!");
                this.email = value;
            }
        }
        public override string ToString()
        {
            return string.Format("My name is {0}.\nI am {1} years old.\n", this.Name, this.Age) +
                (this.Email == null?"I have no email..." : "My email is " + this.Email);
        }
    }
}
