
using EmployeePolymorphism.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePolymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ManagerSalary();
            //DeveloperSalary();
            //QualityAnalystSalary();
        }
        private static void QualityAnalystSalary()
        {
            QualityAnalyst qualityAnalyst = new QualityAnalyst("Jay", 68, 6000);
            Console.WriteLine($"\nCalcAnnualSalary function:"+qualityAnalyst.CalculateAnnualSalary(6000)+"" +
                "\nof Quality Analyst"); 
            qualityAnalyst.PrintSalary(6000,"Salary of Quality Analyst");
        }
        private static void DeveloperSalary()
        {
            Developer developer = new Developer("Mahesh", 66, 8000);
            developer.PrintSalary(6000,"Salary of Developer");
        }
        private static void ManagerSalary()
        {
            Manager manager = new Manager("vikrant", 67, 10000);
            Console.WriteLine("Manager.Calc*****"+manager.CalculateAnnualSalary(10000));
            manager.PrintSalary(10000, "Salary of Manager");
        }
    }
}
