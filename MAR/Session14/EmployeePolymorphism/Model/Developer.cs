using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePolymorphism.Model
{
    internal class Developer : Employee
    {
        private double _performanceAllowance;
        public Developer(int id, string name, double basicSalary) : base(id, name, basicSalary)
        {
            _performanceAllowance = basicSalary * .5;
        }
        public override double CostToCompany
        {
            get { return (_performanceAllowance + BasicSalary) * 12; }
        }
        public override string Role { get { return "Developer"; } }
        public override string SalaryBreakUp
        {
            get
            {
                return "House Rent Allowance :" + _performanceAllowance+"\n";
            }
        }
        public double PerformanceAllowance { get { return _performanceAllowance; } }
    }
}
