using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePolymorphism.Model
{
    internal class Developer:Employee
    {
        double _pa;
        double _ota;
        public Developer(string name, int id, double basic)
            : base(name, id, basic)
        {

        }
        public override void PrintSalary(double basic,string description)
        {
            Console.WriteLine("\n" + description);
            _pa = basic * 50 / 100;
            _ota = basic * 40 / 100;
            Console.WriteLine($"Basic :{basic}\nHRA: {_pa}\nTA :{_ota}\n" +
                $"Total :{basic+_ota+_pa}\nannual salary " +
                $":{CalculateAnnualSalary(basic)}");
        }
        public override double CalculateAnnualSalary(double basic)
        {
            double annualSalary;
            annualSalary = (basic + _pa + _ota) * 12;
            return annualSalary;
        }
    }
}
