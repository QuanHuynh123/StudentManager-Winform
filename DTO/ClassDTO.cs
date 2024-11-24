using System;

namespace DTO
{
    public class ClassDTO
    {
        public int ClassID { get; set; }
        public string ClassName { get; set; } = string.Empty;
        public string Room { get; set; }
        public int SubjectID { get; set; }
        public int TeacherID { get; set; }
        public int StartPeriod { get; set; }
        public int EndPeriod { get; set; }
        public int Day { get; set; }
        public DateTime? StartDate { get; set; } = default;
        public DateTime? EndDate { get; set; } = default;
        public SubjectDTO Subject { get; set; }
        public TeacherDTO Teacher { get; set; }
    }
}
