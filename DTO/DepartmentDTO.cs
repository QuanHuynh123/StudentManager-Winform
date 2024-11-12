using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DepartmentDTO
    {
        private int departmentID;
        private string departmentName;
        private string headOfDepartment;
        private string email;
        private int establishedYear;

        public int GetDepartmentID() { return departmentID; }
        public void SetDepartmentID(int value) { departmentID = value; }

        public string GetDepartmentName() { return departmentName; }
        public void SetDepartmentName(string value) { departmentName = value; }

        public string GetHeadOfDepartment() { return headOfDepartment; }
        public void SetHeadOfDepartment(string value) { headOfDepartment = value; }

        public string GetEmail() { return email; }
        public void SetEmail(string value) { email = value; }

        public int GetEstablishedYear() { return establishedYear; }
        public void SetEstablishedYear(int value) { establishedYear = value; }
    }
}
