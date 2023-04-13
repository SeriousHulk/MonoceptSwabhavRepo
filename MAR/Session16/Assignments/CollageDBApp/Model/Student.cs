using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollageDBApp.Model
{
    internal class Student : IPerson
    {
        private string _name;
        private string _address;
        private int _id;
        private int _age;
        private DateTime _dob;
        public Student(string name, string branch, string address, int id, DateTime dob)
        {
            this._name = name;
            this._address = address;
            this._id = id;
            this._dob = dob;
            this._age = CalculateAge(dob);
        }
        public enum Branch
        {
            ComputerScienceandEngineering,
            IT,
            Electronics,
            Chemical,
            Textile
        }
        public int Age { get => _age; set => _age = value; }
        public string Name { get => _name; set => _name = value; }
        public string Address { get => _address; set => _address = value; }
        public decimal Salary { get => Salary; set => Salary = value; }
        public DateTime Dob { get => _dob; set => _dob = value; }
        public int Id { get => _id; set => _id = value; }

        public decimal CalulateAnnualSalary(decimal salary)
        {
            throw new NotImplementedException();
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
