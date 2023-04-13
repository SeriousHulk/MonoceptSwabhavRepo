using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePolymorphism.Model
{
    internal class QualityAnalyst : Manager
    {
        double _perks;
        public QualityAnalyst(string name, int id, double basic) : base(name, id, basic)
        {
        }
        public override void PrintSalary(double basic, string description)
        {
            Console.WriteLine("\n" + description);
            _perks = basic * 40 / 100;
            Console.WriteLine($"Basic :{basic}\nPerks: {_perks}\n" +
                $"Total :{basic +_perks}\nannual salary :{CalculateAnnualSalary(basic)}");
        }
        public override double CalculateAnnualSalary(double basic)
        {
            double annualSalary;
            annualSalary = (basic+_perks)*12;
            return annualSalary;
        }
    }
}
