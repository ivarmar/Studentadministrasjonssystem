using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studentadministrasjonssystem
{
    internal class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string StudentProgram { get; set; }
        public int StudentID { get; set; }

        public Student(string name, int age, string studentProgram, int studentID)
        {
            Name = name;
            Age = age;
            StudentProgram = studentProgram;
            StudentID = studentID;
        }



        public void GetStudentInfo()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine();
            Console.WriteLine("---------------------");
            Console.WriteLine($"Student name:{Name}");
            Console.WriteLine($"Student age: {Age}");
            Console.WriteLine($"Student Program:{StudentProgram}");
            Console.WriteLine($"Student ID:{StudentID}");
            Console.WriteLine("---------------------");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
