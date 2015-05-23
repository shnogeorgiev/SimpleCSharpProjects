using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ExcelLibrary.CompoundDocumentFormat;
using ExcelLibrary.SpreadSheet;

namespace Excel
{
    public enum StudentType { Onsite, Online }

    public enum Gender { Male, Female }

    class Program
    {
        static void Main(string[] args)
        {
            //The Students-data.txt and table.xls files can be found in the
            //...Functional Programming\Functional Programming\Excel\bin\Debug folder
            //ExcelLibrary.dll is in ...Functional Programming\Functional Programming\Excel\bin

            Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("en-GB");

            IList<Student> AllStudents = new List<Student>();

            using (StreamReader inputData = new StreamReader("Students-data.txt"))
            {
                //I removed the first line from the .txt file to ease my access to the data.
                //Only the actual student data is left in the file.

                for (int i = 0; i < 1000; i++)
                {
                    string[] currentLine = inputData.ReadLine().Split();

                    int id = int.Parse(currentLine[0]);

                    string firstName = currentLine[1];
                    string lastName = currentLine[2];
                    string email = currentLine[3];

                    Gender gender = currentLine[4].Equals("Male")
                        ? gender = Gender.Male : gender = Gender.Female;

                    StudentType studentType = currentLine[5].Equals("Onsite")
                        ? studentType = StudentType.Onsite : studentType = StudentType.Online;

                    int examResult = int.Parse(currentLine[6]);
                    int homeworkSent = int.Parse(currentLine[7]);
                    int homeworkEvaluated = int.Parse(currentLine[8]);
                    double teamWork = double.Parse(currentLine[9]);
                    int attendances = int.Parse(currentLine[10]);
                    double bonus = double.Parse(currentLine[11]);

                    Student student = new Student(id, firstName, lastName, email, gender, studentType, examResult, homeworkSent,
                        homeworkEvaluated, teamWork, attendances, bonus);
                    AllStudents.Add(student);
                }
            }

            Workbook workBook = new Workbook();
            Worksheet workSheet = new Worksheet("Students");

            workSheet.Cells[0, 0] = new Cell("ID");
            workSheet.Cells[0, 1] = new Cell("First Name");
            workSheet.Cells[0, 2] = new Cell("Last Name");
            workSheet.Cells[0, 3] = new Cell("Email");
            workSheet.Cells[0, 4] = new Cell("Gender");
            workSheet.Cells[0, 5] = new Cell("Student Type");
            workSheet.Cells[0, 6] = new Cell("Exam Result");
            workSheet.Cells[0, 7] = new Cell("Homework Sent");
            workSheet.Cells[0, 8] = new Cell("Homework Evaluated");
            workSheet.Cells[0, 9] = new Cell("Teamwork");
            workSheet.Cells[0, 10] = new Cell("Attendances");
            workSheet.Cells[0, 11] = new Cell("Bonus");
            workSheet.Cells[0, 12] = new Cell("Result");

            workSheet.Cells.ColumnWidth[0, 0] = 4000;
            workSheet.Cells.ColumnWidth[0, 1] = 4000;
            workSheet.Cells.ColumnWidth[0, 2] = 4000;
            workSheet.Cells.ColumnWidth[0, 3] = 4000;
            workSheet.Cells.ColumnWidth[0, 4] = 4000;
            workSheet.Cells.ColumnWidth[0, 5] = 4000;
            workSheet.Cells.ColumnWidth[0, 6] = 4000;
            workSheet.Cells.ColumnWidth[0, 7] = 4000;
            workSheet.Cells.ColumnWidth[0, 8] = 5000;
            workSheet.Cells.ColumnWidth[0, 9] = 4000;
            workSheet.Cells.ColumnWidth[0, 10] = 4000;
            workSheet.Cells.ColumnWidth[0, 11] = 4000;
            workSheet.Cells.ColumnWidth[0, 12] = 4000;

            AllStudents = AllStudents.OrderBy(student => student.sType.ToString()).ThenByDescending(student => student.Result)
                .ThenByDescending(student => student.ExamResult).ToList();

            for (int i = 0; i < 1000; i++)
            {
                Student student = AllStudents[i];
                workSheet.Cells[i + 1, 0] = new Cell(student.ID);
                workSheet.Cells[i + 1, 1] = new Cell(student.FirstName);
                workSheet.Cells[i + 1, 2] = new Cell(student.LastName);
                workSheet.Cells[i + 1, 3] = new Cell(student.Email);
                workSheet.Cells[i + 1, 4] = new Cell(student.sGender.ToString());
                workSheet.Cells[i + 1, 5] = new Cell(student.sType.ToString());
                workSheet.Cells[i + 1, 6] = new Cell(student.ExamResult);
                workSheet.Cells[i + 1, 7] = new Cell(student.HomeworkSent);
                workSheet.Cells[i + 1, 8] = new Cell(student.HomeworkEvaluated);
                workSheet.Cells[i + 1, 9] = new Cell(string.Format("{0:f2}", student.TeamWork));
                workSheet.Cells[i + 1, 10] = new Cell(student.Attendances);
                workSheet.Cells[i + 1, 11] = new Cell(string.Format("{0:f2}", student.Bonus));
                workSheet.Cells[i + 1, 12] = new Cell(string.Format("{0:f2}", student.Result));
            }

            workBook.Worksheets.Add(workSheet);
            string path = "table.xls";
            workBook.Save(path);

            Workbook book = Workbook.Load(path);
            Worksheet sheet = book.Worksheets[0];
        }
    }
    public class Student
    {
        private int id;

        private string firstName;
        private string lastName;
        private string email;

        private int examResult;
        private int homeworkSent;
        private int homeworkEvaluated;
        private int attendances;

        private double teamWork;
        private double bonus;

        private StudentType studentType;
        private Gender gender;

        public Student(int id, string firstName, string lastName, string email, Gender gender, StudentType studentType, int examResult,
            int homeworkSent, int homeworkEvaluated, double teamWork, int attendances, double bonus)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Email = email;
            this.sGender = gender;
            this.sType = studentType;
            this.ExamResult = examResult;
            this.HomeworkSent = homeworkSent;
            this.HomeworkEvaluated = homeworkEvaluated;
            this.TeamWork = teamWork;
            this.Attendances = attendances;
            this.Bonus = bonus;
            this.ID = id;
            CalculateResult();
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }


        public int ExamResult { get; set; }
        public int HomeworkSent { get; set; }
        public int HomeworkEvaluated { get; set; }
        public int Attendances { get; set; }


        public double TeamWork { get; set; }
        public double Bonus { get; set; }


        public StudentType sType { get; set; }
        public Gender sGender { get; set; }


        public int ID { get; set; }


        public double Result { get; set; }
        private void CalculateResult()
        {
            this.Result = (this.ExamResult + this.HomeworkSent + this.HomeworkEvaluated + this.TeamWork + this.Attendances + Bonus) / 5;
        }
    }
}
