using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod1_SA
{
    class Program
    {
        static void Main(string[] args)
        {
            UProgram program = new UProgram("Information Technology");
            Student student1 = new Student("Roberto", "Francis", 0588);
            Student student2 = new Student("Roberto", "Kenneth", 9999);
            Student student3 = new Student("Sarmiento", "Israel", 0590);
            Teacher teacher = new Teacher("Oca", "Felix");
            Course course = new Course("Programming with C#");
            Degree degree = new Degree("Bachelor");

            course.Students = new Student[3] { student1, student2, student3 };          
            course.Teachers = new Teacher[1] { teacher };
            degree.Courses = new Course[1] { course };
            program.Degrees = new Degree[1] { degree };

            Console.WriteLine($"Program: { program.Name}");
            Console.WriteLine($"Degree: { degree.Name}");
            Console.WriteLine($"Course: { course.Name}");
            Console.WriteLine($"Number of Students: { course.Students.Count()}");




        }
    }
}
