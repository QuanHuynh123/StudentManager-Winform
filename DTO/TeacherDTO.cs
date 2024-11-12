using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TeacherDTO
    {
        private int teacherID;
        private string firstName;
        private string lastName;
        private bool gender; // true for Male, false for Female
        private string email;
        private string phoneNumber;
        private bool status; // true for Active, false for Inactive
        private int departmentID;
        private string username;
        private string password;
        private int roleID;

        public int GetTeacherID() { return teacherID; }
        public void SetTeacherID(int value) { teacherID = value; }

        public string GetFirstName() { return firstName; }
        public void SetFirstName(string value) { firstName = value; }

        public string GetLastName() { return lastName; }
        public void SetLastName(string value) { lastName = value; }

        public bool GetGender() { return gender; }
        public void SetGender(bool value) { gender = value; }

        public string GetEmail() { return email; }
        public void SetEmail(string value) { email = value; }

        public string GetPhoneNumber() { return phoneNumber; }
        public void SetPhoneNumber(string value) { phoneNumber = value; }

        public bool GetStatus() { return status; }
        public void SetStatus(bool value) { status = value; }

        public int GetDepartmentID() { return departmentID; }
        public void SetDepartmentID(int value) { departmentID = value; }

        public string GetUsername() { return username; }
        public void SetUsername(string value) { username = value; }

        public string GetPassword() { return password; }
        public void SetPassword(string value) { password = value; }

        public int GetRoleID() { return roleID; }
        public void SetRoleID(int value) { roleID = value; }
    }
}
