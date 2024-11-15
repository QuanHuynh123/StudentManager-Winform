using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class StudentDTO
    {
        private int studentID;
        private string fullName;
        private bool gender; // true for Male, false for Female
        private int age;
        private string email;
        private string phoneNumber;
        private DateTime enrollmentDate;
        private int gpa;
        private int totalCreditsEarned;
        private string hometown;
        private string permanentAddress;
        private string studentClass;
        private int departmentID;
        private int programID;
        private int teacherID;

        public int GetStudentID() { return studentID; }
        public void SetStudentID(int value) { studentID = value; }

        public string GetFullName() { return fullName; }
        public void SetFullName(string value) { fullName = value; }

        public bool GetGender() { return gender; }
        public void SetGender(bool value) { gender = value; }

        public int GetAge() { return age; }
        public void SetAge(int value) { age = value; }

        public string GetEmail() { return email; }
        public void SetEmail(string value) { email = value; }

        public string GetPhoneNumber() { return phoneNumber; }
        public void SetPhoneNumber(string value) { phoneNumber = value; }

        public DateTime GetEnrollmentDate() { return enrollmentDate; }
        public void SetEnrollmentDate(DateTime value) { enrollmentDate = value; }

        public int GetGpa() { return gpa; }
        public void SetGpa(int value) { gpa = value; }

        public int GetTotalCreditsEarned() { return totalCreditsEarned; }
        public void SetTotalCreditsEarned(int value) { totalCreditsEarned = value; }

        public string GetHometown() { return hometown; }
        public void SetHometown(string value) { hometown = value; }

        public string GetPermanentAddress() { return permanentAddress; }
        public void SetPermanentAddress(string value) { permanentAddress = value; }

        public string GetStudentClass() { return studentClass; }
        public void SetStudentClass(string value) { studentClass = value; }

        public int GetDepartmentID() { return departmentID; }
        public void SetDepartmentID(int value) { departmentID = value; }

        public int GetProgramID() { return programID; }
        public void SetProgramID(int value) { programID = value; }

        public int GetTeacherID() { return teacherID; }
        public void SetTeacherID(int value) { teacherID = value; }
    }
}