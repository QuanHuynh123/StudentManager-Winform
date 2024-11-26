namespace DTO
{
    public class DepartmentDTO
    {
        public int DepartmentID {  get; set; }
        public string DepartmentName { get; set; }
        public int TeacherID { get; set; }
        public string Email { get; set; }
        public int EstablishedYear { get; set; }
        public TeacherDTO Teacher { get; set; }
    }
}
