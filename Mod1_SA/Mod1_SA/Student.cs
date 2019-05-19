using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod1_SA
{
    public class Student
    {
        //private member variables
        private string firstName;
        private string lastName;
        private static int studentCount;
        
        //auto-implemented property
        public int StudentNumber { get; set; }

        //auto-implement property in a different style
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }

        //constructors
        public Student(string lastName, string firstName, int studentNumber)
        {
            this.FirstName = firstName;
            this.lastName = lastName;
            this.StudentNumber = studentNumber;
            studentCount++;
        }

        public Student(int studentNumber)
        {
            this.StudentNumber = studentNumber;
            studentCount++;

        }

        public Student(string lastName)
        {
            this.LastName = lastName;
        }

        public Student(string lastName, string firstName)
        {
            this.FirstName = firstName;
            this.lastName = lastName;
            studentCount++;
        }

        public Student()
        {
            studentCount++;
        }

        public static int CountStudents()
        {
            return studentCount;
        }
    }
}
