namespace CollageDetailsApp.Model
{
    internal class Collage
    {
        public Collage(string collageName, int collageId)
        {
            CollageName = collageName;
            CollageId = collageId;
            Student = new List<Student>();
            Professor = new List<Professor>();
            Department = new List<Department>();
        }
        public string CollageName { get; set; }
        public int CollageId { get; set; }
        public List<Student> Student { get; set; }
        public List<Professor> Professor { get; set; }
        public List<Department> Department { get; set; }
        public void AddStudent(Student student)
        {
            Student.Add(student);
        }
        public void AddProfessor(Professor professor)
        {
            Professor.Add(professor);
        }
        public void AddDepartment(Department department)
        {
            Department.Add(department);
        }
    }
}
