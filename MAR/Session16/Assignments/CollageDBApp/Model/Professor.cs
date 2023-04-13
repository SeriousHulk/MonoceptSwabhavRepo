using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollageDBApp.Model
{
    internal class Professor : IPerson
    {
        private string _name;
        private string _address;
        private decimal _salary;
        private int _age;
        private int _id;
        private DateTime _dob;
        public Professor(string name, string address, decimal salary, int id, DateTime dob)
        {
            _name = name;
            _address = address;
            _salary = salary;
            _id = id;
            _age = CalculateAge(dob);
            _dob = dob;
        }
        public int Age { get => _age; set => _age = value; }
        public string Name { get => _name; set => _name = value; }
        public string Branch { get; set; }
        public string Address { get => _address; set => _address = value; }
        public decimal Salary { get => _salary; set => _salary = value; }
        public DateTime Dob { get => _dob; set => _dob = value; }
        public int Id { get => _id; set => _id = value; }

        public decimal CalulateAnnualSalary(decimal salary)
        {
            decimal annualsalary;
            annualsalary = salary * 12;
            return annualsalary;
        }
        private int CalculateAge(DateTime dateOfBirth)
        {
            int age = DateTime.Now.Year - dateOfBirth.Year;
            if (DateTime.Now.DayOfYear < dateOfBirth.DayOfYear)
            {
                age--;
            }
            return age;
        }
    }
}
