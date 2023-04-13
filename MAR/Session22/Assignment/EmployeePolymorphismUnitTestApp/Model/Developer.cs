using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePolymorphismUnitTestApp.Model
{
    internal class Developer:Employee
    {
        double _pa;
        double _ota;
        public Developer(string name, int id, double basic)
            : base(name, id, basic)
        {
            _pa = basic * 50 / 100;
            _ota = basic * 40 / 100;
        }
        public override void PrintSalary(double basic,string description="Developer Salary")
        {
            if (basic == 0)
                throw new Exception("Basic Salary Cannot be Zero");
            else if (basic < 0)
                throw new Exception("Basic Salary Cannot be Negative");
            Console.WriteLine("\n" + description);
            _pa = basic * 50 / 100;
            _ota = basic * 40 / 100;
            Console.WriteLine($"Basic :{basic}\nHRA: {_pa}\nTA :{_ota}\n" +
                $"Total :{basic+_ota+_pa}\nannual salary " +
                $":{CalculateAnnualSalary(basic)}");
        }
        public override double CalculateAnnualSalary(double basic)
        {
            if (basic == 0)
                throw new Exception("Basic Salary Cannot be Zero");
            else if (basic < 0)
                throw new Exception("Basic Salary Cannot be Negative");
            double annualSalary;
            annualSalary = (basic + _pa + _ota) * 12;
            return annualSalary;
        }
    }
}
