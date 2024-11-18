using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TrainingProgramDTO
    {
        public int ProgramID { get; set; }
        public string ProgramName { get; set; }
        public int DepartmentID { get; set; }
        public int Duration { get; set; }
        public int StartYear { get; set; }
        public int EndYear { get; set; }
        public string DegreeAwarded { get; set; }
        public int CreditsRequired { get; set; }
    }
}
