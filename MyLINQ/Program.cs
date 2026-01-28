using MyLINQ;

internal class Program
{
    private static void Main(string[] args)
    {
        List<Student> students = new List<Student>
        {
            new Student { Id=1, Name="An", Age=20, Gender="Male", DepartmentId=1, GPA=3.2 },
            new Student { Id=2, Name="Mai", Age=21, Gender="Female", DepartmentId=1, GPA=3.8 },
            new Student { Id=3, Name="Chi", Age=19, Gender="Female", DepartmentId=2, GPA=2.9 },
            new Student { Id=4, Name="Dung", Age=22, Gender="Male", DepartmentId=2, GPA=3.5 },
            new Student { Id=5, Name="Huy", Age=20, Gender="Male", DepartmentId=3, GPA=3.9 }
        };

        List<Department> departments = new List<Department>
        {
            new Department { Id=1, Name="Software Engineering" },
            new Department { Id=2, Name="Information Systems" },
            new Department { Id=3, Name="Artificial Intelligence" }
        };

        List<Course> courses = new List<Course>
        {
            new Course { Id=1, Name="PRN212", Credits=3 },
            new Course { Id=2, Name="CSD201", Credits=4 },
            new Course { Id=3, Name="DIB202", Credits=3 }
        };

        List<Enrollment> enrollments = new List<Enrollment>
        {
            new Enrollment { StudentId=1, CourseId=1, Score=8.0 },
            new Enrollment { StudentId=1, CourseId=2, Score=7.5 },
            new Enrollment { StudentId=2, CourseId=1, Score=9.0 },
            new Enrollment { StudentId=3, CourseId=3, Score=6.0 },
            new Enrollment { StudentId=4, CourseId=2, Score=8.5 },
            new Enrollment { StudentId=5, CourseId=1, Score=9.5 }
        };


    }

}