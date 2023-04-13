using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePolymorphismUnitTestApp.Model
{
    internal class QualityAnalyst : Manager
    {
        double _perks;
        public QualityAnalyst(string name, int id, double basic) : base(name, id, basic)
        {
            _perks = basic * 40 / 100;
        }
        public override void PrintSalary(double basic, string description="Quality Analyst Salary")
        {
            if (basic == 0)
                throw new Exception("Basic Salary Cannot be Zero");
            else if (basic < 0)
                throw new Exception("Basic Salary Cannot be Negative");
            Console.WriteLine("\n" + description);
            _perks = basic * 40 / 100;
            Console.WriteLine($"Basic :{basic}\nPerks: {_perks}\n" +
                $"Total :{basic +_perks}\nannual salary :{CalculateAnnualSalary(basic)}");
        }
        public override double CalculateAnnualSalary(double basic)
        {
            if (basic == 0)
                throw new Exception("Basic Salary Cannot be Zero");
            else if (basic < 0)
                throw new Exception("Basic Salary Cannot be Negative");
            double annualSalary;
            annualSalary = (basic+_perks)*12;
            return annualSalary;
        }
    }
}
