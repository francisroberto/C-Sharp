using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod1_SA
{
    class UProgram
    {        
        public string Name { get; set; }
        public string ProgramID { get; set; }

        public Degree[] Degrees { get; set; }

        public UProgram(string name, string programID, Degree[] degrees)
        {
            Name = name;
            ProgramID = programID;
            Degrees = degrees;
        }
        public UProgram(string name, Degree[] degrees)
        {
            Name = name;
            Degrees = degrees;
        }

        public UProgram(string name)
        {
            this.Name = name;
        }

        public UProgram(string name, string programID)
        {
            this.Name = name;
            this.ProgramID = programID;
        }

        public UProgram()
        {

        }
    }
}
