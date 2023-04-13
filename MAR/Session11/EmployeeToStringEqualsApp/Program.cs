using EmployeeToStringEqualsApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeToStringEqualsApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CaseStudy1();
            CaseStudy2();
        }
        private static void CaseStudy1()
        {
            var employee1 = new Employee("Vikrant", 1001, 20000);
            Console.WriteLine(employee1);
            Console.WriteLine(employee1.GetType().ToString());
            Console.WriteLine(employee1.ToString());
        }
        private static void CaseStudy2()
        {
            var employee1 = new Employee("Vikrant", 1001, 20000);
            var employee2 = new Employee("Vikrant", 1001, 20000);
            if (employee2 != employee1)
            {
                Console.WriteLine("true");
            }
            Console.WriteLine(employee2.Equals(employee1)) ;
        }
    }
}
