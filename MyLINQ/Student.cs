using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace MyLINQ
{
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public int DepartmentId { get; set; }
        public double GPA { get; set; }

        public void displayStudent()
        {
            Console.WriteLine($"{Id,-5} {Name,-25} {Age,-5} {Gender,-7} {DepartmentId,-3} {GPA,5}");
        }
    }

    class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public void displayDepartment() => Console.WriteLine($"{Id,-5} {Name,20}");
    }

    class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Credits { get; set; }

        public void displayCourse() => Console.WriteLine($"{Id,-5} {Name,-25} {Credits,5}");
    }

    class Enrollment
    {
        public int StudentId { get; set; }
        public int CourseId { get; set; }
        public double Score { get; set; }

        public void displayEnrollment() => Console.WriteLine($"{StudentId,-5} {CourseId,-5} {Score,5}");
    }

}
