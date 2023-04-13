using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePolymorphism.Model
{
    internal class Manager : Employee
    {
        double _hra;
        double _ta;
        double _da;
        public Manager(string name, int id, double basic) 
            : base(name, id, basic)
        {
            _hra = basic * 60 / 100;
            _ta = basic * 60 / 100;
            _da = basic * 40 / 100;
        }

        public override void PrintSalary(double basic,string description)
        {
            Console.WriteLine("\n"+description);
            _hra = basic * 60 / 100;
            _ta = basic * 60 / 100;
            _da = basic * 40 / 100;
            Console.WriteLine($"Basic :{basic}\nHRA: {_hra}\nTA :{_ta}\nDA :{_da}\n" +
                $"Total Salary :{basic+_hra+_ta+_da}\nannual salary " +
                $":{CalculateAnnualSalary(basic)}");
        }
        public override double CalculateAnnualSalary(double basic)
        {
            double annualSalary;
            annualSalary = (basic + _hra + _ta + _da) * 12;
            return annualSalary;
        }
    }
}
