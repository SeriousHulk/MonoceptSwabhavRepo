using CollageDetailsApp.Model;

namespace CollageDetailsApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Collage collage = new Collage("SGGS", 1919);
            Department civil = new Department(DepartmentName.Civil);
            Department cs = new Department(DepartmentName.Computer_Science);
            Department electronics = new Department(DepartmentName.Electronics);
            Department it = new Department(DepartmentName.Information_Technology);
            Department mech = new Department(DepartmentName.Mechanical);
            Professor balaji = new Professor("Balaji S.", it, 42);
            Professor naveen = new Professor("Naveen", cs, 39);
            Professor megha = new Professor("S. Pandey", electronics, 57);
            Student vikrant = new Student("Vikrant", 12, it, 23);
            Student deepak = new Student("Deepak", 22, cs, 22);
            Student vikrama = new Student("Vikama", 67, it, 21);
            Student rohit = new Student("Rohit", 12, mech, 23);
            collage.AddDepartment(new Department(DepartmentName.Civil));
            collage.AddDepartment(new Department(DepartmentName.Computer_Science));
            collage.AddDepartment(new Department(DepartmentName.Information_Technology));
            collage.AddDepartment(new Department(DepartmentName.Electronics));
            collage.AddDepartment(new Department(DepartmentName.Mechanical));
            collage.AddProfessor(new Professor("Balaji S.", it, 42));
            collage.AddProfessor(new Professor("Naveen", cs, 39));
            collage.AddProfessor(new Professor("S. Pandey", electronics, 57));
            collage.AddStudent(new Student("Vikrant", 12, it, 23));
            collage.AddStudent(new Student("Deepak", 22, cs, 22));
            collage.AddStudent(new Student("Vikama", 67, it, 21));
            collage.AddStudent(new Student("Rohit", 12, mech, 23));

            PrintDetails(collage);
        }

        private static void PrintDetails(Collage collage)
        {
            Console.WriteLine($"Details of {collage} collage");
            Console.WriteLine($"Departments:\n");
            foreach (var department in collage.Department)
            {
                Console.WriteLine($"{department.DepartmentName}");
            }
            Console.WriteLine($"\nProfessors are:");
            foreach (var professor in collage.Professor)
            {
                Console.WriteLine($"Name:{professor.Name}, Age: {professor.Age} and " +
                    $"Department: {professor.Department.DepartmentName}");
            }
            Console.WriteLine($"\nStudents are:");
            foreach (var student in collage.Student)
            {
                Console.WriteLine($"Name:{student.Name}, Age: {student.Age} and " +
                    $"Department: {student.Department.DepartmentName}");
            }
        }
    }
}