using CollageDBApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollageDBApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CaseStudy1();
            CaseStudy2();
        }

        private static void CaseStudy1()
        {
            IPerson student = new Student("Vikrant", "IT", "Nanded", 42, new DateTime(1999, 06, 11));
            Console.WriteLine($"Name of student :{student.Name}");
            Console.WriteLine($"Age of student  :{student.Age}");
            Console.WriteLine($"ID              :{student.Id}");
            Console.WriteLine($"address         :{student.Address}");
            Console.WriteLine($"Branch          :{student.Branch}\n");
        }
        private static void CaseStudy2()
        {
            IPerson professor = new Professor("Pro.Balaji", "Vishnupuri", 70000, 303, new DateTime(1969, 7, 31));
            Console.WriteLine($"Name of Professor:{professor.Name}");
            Console.WriteLine($"ID               :{professor.Id}");
            Console.WriteLine($"address          :{professor.Address}");
            Console.WriteLine($"Date of Birth    :{professor.Dob}");
            Console.WriteLine($"Annual Salary of {professor.Name} is {professor.CalulateAnnualSalary(70000)}");
        }
    }
}
