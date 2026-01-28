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

        //1. Where
        //GPA ≥ 3.5
        var s1 = students.Where(s => s.GPA >= 3.5).ToList();

        foreach (var s in s1)
        {
            s.displayStudent();
        }
        Console.WriteLine("Get female");
        //Get all students are female
        var s2 = students.Where(s => s.Gender == "Female").ToList();
        foreach (var s in s2)
        {
            s.displayStudent();
        }

        //SE department with GPA > 3
        Console.WriteLine("SE department with GPA > 3");
        var s3 = students.Where(s => s.DepartmentId == 1 && s.GPA > 3).ToList();
        foreach (var s in s3)
        {
            s.displayStudent();
        }

        //2. Select (projection)
        //Get Student names
        Console.WriteLine("\n4.Get student names");
        var s4 = students.Select(s => s.Name).ToList();
        foreach (var e in s4)
        {
            Console.WriteLine(e);
        }
        Console.WriteLine("\n5.Get student names, gpa");
        var s5 = students.Select(s => new { s.Name, s.GPA }).ToList();
        foreach (var e in s5)
        {
            Console.WriteLine(e.Name + " - " + $"{e.GPA,5:F2}");
        }

        Console.WriteLine("\n6.Get student id names, age");
        var s6 = students.Select(s => $"{s.Id,-5} {s.Name,-10} {s.Age,5}").ToList();
        foreach (var e in s6)
        {
            Console.WriteLine(e);
        }

        //3. OrderBy/ThenBy
        //Sort by Name in ascending order
        Console.WriteLine("\n7.Sort by Name in ascending order");
        var s7 = students.OrderBy(s => s.Name).ToList();
        foreach(var e in s7)
        {
            e.displayStudent();
        }

        Console.WriteLine("\n8.Sort by GPA in descending order");
        var s8 = students.OrderByDescending(s => s.GPA).ToList();
        foreach (var e in s8)
        {
            e.displayStudent();
        }

        Console.WriteLine("\n9.Sort by Age, then GPA in descending order");
        var s9 = students.OrderBy(s => s.Age)
                .ThenByDescending(s => s.GPA)
                .ToList();
        foreach (var e in s9)
        {
            e.displayStudent();
        }

        //Group by
        var s10 = students.GroupBy(s => s.DepartmentId)
            .Select(g => new { g.Key, Count = g.Count() })
            .ToList();
        foreach (var e in s10)
        {
            Console.WriteLine(e);
        }

        //Count
        Console.WriteLine("\n11. Count number of students");
        var s11 = students.Count();
        Console.WriteLine(s11);

        //Max
        Console.WriteLine("\n12. Get the maximum GPA");
        var s12 = students.Max(s => s.GPA);
        Console.WriteLine(s12);

        //JOIN
        Console.WriteLine("\n13. Get id, name and department name of each students");
        var s13 = students.Join(departments, s => s.DepartmentId, d => d.Id,
                (s, d) => new {s.Id, s.Name, Department = d.Name}).ToList();

        foreach(var e in s13)
        {
            Console.WriteLine(e);
        }

        Console.WriteLine("\n14. Get id, name and course of each students");
        var s14 = enrollments.Join(students, e=>e.StudentId , s => s.Id, (e,s) => new { e, s })
            .Join(courses, es => es.e.CourseId, co =>co.Id, (es,co) => new {es.s.Id, es.s.Name, CouseName=co.Name }).ToList();

        foreach (var e in s14)
        {
            Console.WriteLine(e);
        }


        //Take(n) / Skip (n)
        var s15 = students.Take(2).ToList();
        foreach (var item in s15)
        {
            item.displayStudent();
        }

        Console.WriteLine();
        var s16 = students.Skip(3).ToList();
        foreach (var item in s16)
        {
            item.displayStudent();
        }


    }

}