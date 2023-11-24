using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Studentadministrasjonssystem
{
    internal class Classes
    {
        public int ClassCode { get; set; }
        public string ClassName { get; set; }
        public int ClassPoints { get; set; }

        public Classes (int classCode, string className, int classPoints)
        {
            ClassCode = classCode;
            ClassName = className;
            ClassPoints = classPoints;
        }

        public void GetClassInfo()
        {
            Console.WriteLine();
            Console.WriteLine("---------------------------------");
            Console.WriteLine($"Class Code:{ClassCode}");
            Console.WriteLine($"Class Name:{ClassName}");
            Console.WriteLine($"Class Points:{ClassPoints}");
            Console.WriteLine("---------------------------------");
        }
    }
}
