using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class SubjectDTO
    {
        public int SubjectID { get; set; }
        public string SubjectName { get; set; }
        public int Credits { get; set; }
        public int ProgramID { get; set; }
        public int DepartmentID { get; set; }
    }
}
