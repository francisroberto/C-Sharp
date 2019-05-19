using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod1_SA
{
    public class Degree
    {   
        public string Name { get; set; }
        public string DegreeID { get; set; }
        public Course[] Courses { get; set; }

        public Degree(string name, string degreeID, Course[] courses)
        {
            Name = name;
            DegreeID = degreeID;
            Courses = courses;
        }

        public Degree(string name, string degreeID)
        {
            Name = name;
            DegreeID = degreeID;
        }

        public Degree(string name)
        {
            Name = name;
        }

        public Degree()
        {
        }
    }
}
