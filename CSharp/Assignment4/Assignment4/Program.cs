using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    interface IStudent
    {
        int StudentID { get; set; }
        string Name { get; set; }
        void ShowDetails();
    }

    class DayScholar : IStudent
    {
        public int StudentID { get; set; }
        public string Name { get; set; }

        public void ShowDetails()
        {
            Console.WriteLine("Day Scholar Details");
            Console.WriteLine("Student ID: "+StudentID);
            Console.WriteLine("Student Name: " + Name);
            Console.WriteLine();
        }
    }

    class Resident : IStudent
    {
        public int StudentID { get; set; }
        public string Name { get; set; }

        public void ShowDetails()
        {
            Console.WriteLine("Resident Details");
            Console.WriteLine("Student ID: "+ StudentID);
            Console.WriteLine("Student Name: "+Name);
            Console.WriteLine();
        }
    }

    class Interface
    {
        public static void Main()
        {
            DayScholar days = new DayScholar();
            days.StudentID = 102;
            days.Name = "Shahrukh";
            days.ShowDetails();
            Resident res = new Resident();
            res.StudentID = 102;
            res.Name = "Salman";
            res.ShowDetails();
            Console.Read();
        }
    }
}
