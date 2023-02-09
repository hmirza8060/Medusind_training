using System;


namespace Assignment_2
{
    class Students
    {
        int Rollno;
        string Sname;
        string Class;
        ushort Semester;
        string Branch;
        int[] marks = new int[5];
        public Students(int Rollno, string Sname, string Class, ushort Semester, string Branch, int[] marks)
        {
            this.Rollno = Rollno;
            this.Sname = Sname;
            this.Class = Class;
            this.Semester = Semester;
            this.Branch = Branch;
            this.marks = marks;
        }

        public void Displayresult()
        {
            Console.WriteLine("Enter student details");
            Console.WriteLine($"Student Rollno : {Rollno}");
            Console.WriteLine($"Student name : {Sname}");
            Console.WriteLine($"class : {Class}");
            Console.WriteLine($"Semester : {Semester}");
            Console.WriteLine($"Branch name : {Branch}");
            Console.WriteLine($"Total marks : {marks.Sum()}");
            string Status = marks.Sum() < 35 ? "Fail" : (marks.Sum() / marks.Length) < 50 ? "Fail" : "Pass";
            Console.WriteLine($"Status : {Status}");
        }
    }
}
