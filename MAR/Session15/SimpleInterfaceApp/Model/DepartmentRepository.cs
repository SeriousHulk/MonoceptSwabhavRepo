using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleInterfaceApp.Model
{
    internal class DepartmentRepository : ICrudable
    {
        public void Create()
        {
            Console.WriteLine("Department Record created");
        }
        public void Read()
        {
            Console.WriteLine("Department Record Selected");
        }
        public void Update()
        {
            Console.WriteLine("Department Record Updated");
        }
        public void Delete()
        {
            Console.WriteLine("Department Record Deleted");
        }
    }
}
