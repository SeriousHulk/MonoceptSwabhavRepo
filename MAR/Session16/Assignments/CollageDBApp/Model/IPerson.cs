using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollageDBApp.Model
{
    public interface IPerson
    {
        decimal CalulateAnnualSalary(decimal salary);
        string Name { get; set; }
        string Branch { get; set; }
        string Address { get; set; }
        decimal Salary { get; set; }
        int Age { get; set; }
        DateTime Dob { get; set; }
        int Id { get; set; }
    }
}
