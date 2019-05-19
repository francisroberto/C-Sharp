using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod1_SA
{
    public class Teacher
    {
      
        public string LastName { get; set; }
        public string FirstName { get; set; }
        
        public string TeacherID { get; set; }

        public Teacher(string lastName, string firstName, string teacherID)
        {
            this.LastName = lastName;
            this.FirstName = firstName;
            this.TeacherID = teacherID;
        }

        public Teacher(string lastName)
        {
            this.LastName = lastName;
        }

        public Teacher(string lastName, string firstName)
        {
            this.FirstName = firstName;
        }

        public Teacher()
        {

        }
    }
}
