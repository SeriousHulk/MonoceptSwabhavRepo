using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeToStringEqualsApp.Model
{
    internal class Employee
    {
        private string name;
        private int id;
        private double salary;
        public Employee(string name, int id, double salary)
        {
            this.name = name;
            this.id = id;
            this.salary = salary;
        }
        public override string ToString()
        {

            return $"parent : {base.ToString()}\nid is {id},\n" +
                $" name is {name} \n" +
                $"and salary is {salary}\n";
        }
        public override bool Equals(object obj)
        {
            Employee other = (Employee)obj;
            if (this.Id == other.Id)
                return true;
            return false;
        }
        public int Id { get { return id; }  }
        public string Name { get { return name; } }
        public double Salary { get { return salary; } }
    }
}
