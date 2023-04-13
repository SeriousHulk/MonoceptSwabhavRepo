using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePolymorphism.Model
{
    internal class Manager:Employee
    {
        private double _houseRentAllowance;
        private double _travellingAllowance;
        public Manager(int id,string name,double basicSalary) : base(id, name, basicSalary)
        {
            _houseRentAllowance = basicSalary * .15;
            _travellingAllowance = basicSalary * .2;
        }

        public override double CostToCompany
        {
            get { return (_houseRentAllowance+BasicSalary+_travellingAllowance)*12; }
        }

        public override string Role { get { return "Manager"; } }

        public override string SalaryBreakUp { get{
                string formattedSalaryBreakup = "";
                formattedSalaryBreakup += "House Rent Allowance :" + _houseRentAllowance ;
                formattedSalaryBreakup += " Traveling Allowance :" + _travellingAllowance;
                formattedSalaryBreakup += "\n";
                return formattedSalaryBreakup;
            } }
        public double HouseRentAllowance { get { return _houseRentAllowance; } }
        public double TravelingAllowance { get { return _travellingAllowance; } }
    }
}
