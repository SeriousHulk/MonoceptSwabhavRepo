using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentLinkApp.Model
{
    internal class Student
    {
        public string Name { get; set; }
        public Student Buddy { get; set; }
        public void PrintBuddies(Student root)
        {
            while (root != null)
            {
                Console.WriteLine($"{root.Name}'s buddy is {root.Buddy.Name}");
                root = root.Buddy;
            }
        }
    }
}
