namespace CollageDetailsApp.Model
{
    internal class Student
    {
        public Student(string name, int rollNo, Department department, int age)
        {
            Name = name;
            RollNo = rollNo;
            Department = department;
            Age = age;
        }
        public string Name { get; set; }
        public int RollNo { get; set; }
        public Department Department { get; set; }
        public int Age { get; set; }       
    }
}
