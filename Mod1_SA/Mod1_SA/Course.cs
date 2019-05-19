using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod1_SA
{
    public class Course
    {
        private string name;
        private string courseID;

        public Student[] Students { get; set; }
        public Teacher[] Teachers { get; set; }
        

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public string CourseID
        {
            get
            {
                return courseID;
            }
            set
            {
                courseID = value;
            }
        }

        //public string CourseID{ get => courseID; set => courseID = value; }

        public Course(string name, string courseID)
        {
            this.Name = name;
            this.CourseID = courseID;
        }

        public Course(string name)
        {
            this.Name = name;
        }

        public Course(Student[] students)
        {
            Students = students;
        }
        public Course()
        {
        }
    }
}
