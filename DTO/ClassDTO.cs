using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ClassDTO
    {
        public int ClassId { get; set; }
        public string ClassName { get; set; }
        public string Room { get; set; }
        public int SubjectId { get; set; }
        public int TeacherId { get; set; }
        public int StartPeriod { get; set; }
        public int EndPeriod { get; set; }
        public int Day { get; set; }
    }
}
