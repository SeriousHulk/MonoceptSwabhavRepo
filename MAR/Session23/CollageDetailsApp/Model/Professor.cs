using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollageDetailsApp.Model
{
    internal class Professor
    {
        public Professor(string name, Department department, int age)
        {
            Name = name;
            Department = department;
            Age = age;
        }
        public string Name { get; set; }
        public int Age { get; set; }
        public Department Department { get; set; }
    }
}
