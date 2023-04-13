using EmployeePolymorphism.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePolymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var manager = new Manager(1000, "Vikrant", 40000);
            var developer = new Developer(1009,"Dinesh",39000);
            PrintSalarySlipToConsole(manager);
            PrintSalarySlipToConsole(developer);
            PrintSalarySlipToHtml(manager);
            PrintSalarySlipToHtml(developer);
        }
        static void PrintSalarySlipToConsole(Employee employee)
        {
            Console.WriteLine($"Employee Name is :{employee.Name}");
            Console.WriteLine($"Employee ID is :{employee.Id}");
            Console.WriteLine($"Employee Salary is :{employee.BasicSalary}");
            Console.WriteLine($"Employee CTC is :{employee.CostToCompany}");
            Console.WriteLine($"Employee Role is :{employee.Role}");
            Console.WriteLine($"their salary breakup :{employee.SalaryBreakUp}");
        }
        static void PrintSalarySlipToHtml(Employee employee)
        {
            StreamWriter streamWriter = new StreamWriter(employee.Name+".html");
            streamWriter.WriteLine("<Body>");
            streamWriter.WriteLine("<H1>");
            streamWriter.WriteLine($"Employee Name is :{employee.Name}");
            streamWriter.WriteLine("</br>");
            streamWriter.WriteLine($"Employee ID is :{employee.Id}");
            streamWriter.WriteLine("</br>");
            streamWriter.WriteLine($"Employee Salary is :{employee.BasicSalary}");
            streamWriter.WriteLine("</br>");
            streamWriter.WriteLine($"Employee CTC is :{employee.CostToCompany}");
            streamWriter.WriteLine("</br>");
            streamWriter.WriteLine($"Employee Role is :{employee.Role}");
            streamWriter.WriteLine("</br>");
            streamWriter.WriteLine($"their salary breakup :{employee.SalaryBreakUp}");
            streamWriter.WriteLine("</H1>");
            streamWriter.WriteLine("</Body>");
            streamWriter.Close();
            Console.WriteLine("Html File Created");
        }
    }
}
