using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class SubjectDTO
    {
        private int subjectID;
        private string subjectName;
        private int credits;
        private int programID;
        private int departmentID;

        public int GetSubjectID() { return subjectID; }
        public void SetSubjectID(int value) { subjectID = value; }

        public string GetSubjectName() { return subjectName; }
        public void SetSubjectName(string value) { subjectName = value; }

        public int GetCredits() { return credits; }
        public void SetCredits(int value) { credits = value; }

        public int GetProgramID() { return programID; }
        public void SetProgramID(int value) { programID = value; }

        public int GetDepartmentID() { return departmentID; }
        public void SetDepartmentID(int value) { departmentID = value; }
    }
}
