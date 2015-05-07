using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Defining_Classes___04.S.U.L.S
{
    class Program
    {
        static void Main(string[] args)
        {
            //Software University Learning System

            Person person = new Person("Ivan", "Petrov", 27);
            Console.WriteLine("Person");
            Console.WriteLine("Hello {0} {1}!", person.FirstName, person.LastName);

            Console.WriteLine();

            Student student = new Student("Dimitar", "Lubenov", 19, 255888, 5.25);
            Console.WriteLine("Student");
            Console.WriteLine("Hello {0} {1}!\n#{2} || GRADE: {3:f2}", student.FirstName, student.LastName, student.Number, student.Grade);

            Console.WriteLine();

            GraduateStudent graduateStudent = new GraduateStudent("Danail", "Mladenov", 21, 995434, 4.75);
            Console.WriteLine("Graduate Student");
            Console.WriteLine("Hello {0} {1}!\n#{2} || GRADE: {3:f2}", graduateStudent.FirstName, graduateStudent.LastName, 
                graduateStudent.Number, graduateStudent.Grade);

            Console.WriteLine();

            DropoutStudent dropoutStudent = new DropoutStudent("Andon", "Andonov", 26, 112564, 2.70, "Idleness breeds degradation");
            Console.WriteLine("Dropout Student");
            Console.WriteLine("Dropout Reason: "+dropoutStudent.DropoutReason);
            Console.WriteLine("Hello {0} {1}!\n#{2} || GRADE: {3:f2}", dropoutStudent.FirstName, dropoutStudent.LastName,
                dropoutStudent.Number, dropoutStudent.Grade);

            Console.WriteLine();

            CurrentStudent currentStudent = new CurrentStudent("Vahan", "Petev", 18, 334569, 5.50, "C# Basics 2015 April");
            Console.WriteLine("Current Student");
            Console.WriteLine("Current Course: "+currentStudent.CurrentCourse);
            Console.WriteLine("Hello {0} {1}!\n#{2} || GRADE: {3:f2}", currentStudent.FirstName, currentStudent.LastName,
                currentStudent.Number, currentStudent.Grade);

            Console.WriteLine();

            OnlineStudent onlineStudent = new OnlineStudent("Peter", "Georgiev", 18, 333111, 6.00, "C# Object Orientated Programming 2015");
            Console.WriteLine("Online Student");
            Console.WriteLine("Current Course: "+onlineStudent.CurrentCourse);
            Console.WriteLine("Hello {0} {1}!\n#{2} || GRADE: {3:f2}", onlineStudent.FirstName, onlineStudent.LastName,
                onlineStudent.Number, onlineStudent.Grade);

            Console.WriteLine();

            OnsiteStudent onsiteStudent = new OnsiteStudent("Mario", "Milev", 20, 959523, 5.75, "Javascript Applications 2015", 23);
            Console.WriteLine("Onsite Student");
            Console.WriteLine("Current Course: " + onsiteStudent.CurrentCourse);
            Console.WriteLine("Hello {0} {1}!\n#{2} || GRADE: {3:f2} || VISITS: {4}", onsiteStudent.FirstName, onsiteStudent.LastName,
                onsiteStudent.Number, onsiteStudent.Grade, onsiteStudent.NumberOfVisits);

            Console.WriteLine();

            Trainer trainer = new Trainer("Ivelin", "Ivelinov", 15);
            Console.WriteLine("Trainer");
            Console.WriteLine("Hello {0} {1}!", trainer.FirstName, trainer.LastName);
            trainer.CreateCourse("Java Basics May 2015");
            Console.WriteLine();

            SeniorTrainer seniorTrainer = new SeniorTrainer("Svetlin", "Nakov", 35);
            Console.WriteLine("Senior Trainer");
            Console.WriteLine("Hello {0} {1}!", seniorTrainer.FirstName, seniorTrainer.LastName);
            seniorTrainer.DeleteCourse("HTML & CSS Basics April 2015");

            Console.WriteLine();

            JuniorTrainer juniorTrainer = new JuniorTrainer("Angel", "Georgiev", 20);
            Console.WriteLine("Junior Trainer");
            Console.WriteLine("Hello {0} {1}!", juniorTrainer.FirstName, juniorTrainer.LastName);
        }
    }
}
