using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePolymorphism.Model
{
    internal abstract class Employee
    {
        readonly string _name;
        readonly int _id;
        readonly double _basic;
        public Employee(string name, int id, double basic)
        {
            _name = name;
            _id = id;
            _basic = basic;
        }
        public string Name { get { return _name;} }
        public int Id { get { return _id;} }
        public double Basic { get { return _basic;} }
        public abstract void PrintSalary(double basic,string description);
        public abstract double CalculateAnnualSalary(double basic);
    }
}
