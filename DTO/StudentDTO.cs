using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class StudentDTO
    {
        public int StudentID { get; set; }
        public string FullName { get; set; }
        public bool Gender { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime EnrollmentDate { get; set; }
        public int Gpa { get; set; }
        public int TotalCreditsEarned { get; set; }
        public string Hometown { get; set; }
        public string PermanentAddress { get; set; }
        public string Class { get; set; }
        public int DepartmentID { get; set; }
        public int ProgramID { get; set; }
    }
}