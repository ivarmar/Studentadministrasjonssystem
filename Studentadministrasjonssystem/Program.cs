using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.ComTypes;
using System.Xml.Linq;

namespace Studentadministrasjonssystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            var classList = new List<Classes>();
            var studentList = new List<Student>();
            while (true)
            {
                Console.WriteLine("1.Press 's' to add student.\n2.Press 'g' to show Grades.\n3.Press 'f' to add classes.\n4.Press 'x' to continue.");
                string userInput = Console.ReadLine();

                if (userInput == "x")
                {
                    break;
                }
                switch (userInput)
                {
                    case "s":
                        studentList.Add(new Student(GetName(), GetAge(), GetStudentProgram(), GetStudentID()));
                        break;
                    case "f":
                        classList.Add(new Classes(GetClassCode(), GetClassName(), GetClassPoints()));
                        break;
                }
            }

            while (true)
            {
                Console.WriteLine("1.Press '1' to show the list of students.\n2.Press '2' to show list of classes.");
                string userInput1 = Console.ReadLine();
                switch (userInput1)
                {
                    case "1":
                    {
                        Console.WriteLine("Current students list:");
                        foreach (var s in studentList)
                        {
                            s.GetStudentInfo();
                        }

                        break;
                    }
                    case "2":
                    {
                        Console.WriteLine("Current Class list:");
                        foreach (var f in classList)
                        {
                            f.GetClassInfo();
                        }

                        break;
                    }
                }
            }

        }
        public static string GetName()
        {
            Console.WriteLine("What is the students name?");
            return Console.ReadLine();

        }

        public static int GetAge()
        {
            Console.WriteLine("Age:");
            return Convert.ToInt32(Console.ReadLine());

        }

        public static string GetStudentProgram()
        {
            Console.WriteLine("What program is the student in?");
            return Console.ReadLine();

        }

        public static int GetStudentID()
        {
            Console.WriteLine("What is the student ID?");
            return Convert.ToInt32(Console.ReadLine());
            
        }

        ///////////////////////////////////////////////////////////////////////////
        public static int GetClassCode()
        {
            Console.WriteLine("What is the 'code' to the class?");
            return Convert.ToInt32(Console.ReadLine());
        }

        public static string GetClassName()
        {
            Console.WriteLine("Name the class:");
            return Console.ReadLine();
        }

        public static int GetClassPoints()
        {
            Console.WriteLine("How many points do the students get for completing the class?");
            return Convert.ToInt32(Console.ReadLine());
        }

        ////////////////////////////////////////////////////////////////////////////
        

    }
}