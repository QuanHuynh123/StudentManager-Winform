namespace DTO.Models
{
    public class ClassForExport
    {
        public int ClassID { get; set; }
        public string ClassName { get; set; } = string.Empty;
        public string Room { get; set; }
        public string SubjectName { get; set; }
        public string TeacherName { get; set; }
        public int StartPeriod { get; set; }
        public int EndPeriod { get; set; }
        public int Day { get; set; }
    }
}
