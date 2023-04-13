using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollageDetailsApp.Model
{
    internal class Department
    {
        public Department(DepartmentName departmentName)
        {
            DepartmentName = departmentName;
        }
        public DepartmentName DepartmentName { get; set; }
    }
}
