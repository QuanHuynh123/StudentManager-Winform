using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TrainingProgramDTO
    {
        private int programID;
        private string programName;
        private int departmentID;
        private int duration;
        private int startYear;
        private int endYear; // Nullable type
        private string degreeAwarded;
        private int creditsRequired;

        public int GetProgramID() { return programID; }
        public void SetProgramID(int value) { programID = value; }

        public string GetProgramName() { return programName; }
        public void SetProgramName(string value) { programName = value; }

        public int GetDepartmentID() { return departmentID; }
        public void SetDepartmentID(int value) { departmentID = value; }

        public int GetDuration() { return duration; }
        public void SetDuration(int value) { duration = value; }

        public int GetStartYear() { return startYear; }
        public void SetStartYear(int value) { startYear = value; }

        public int? GetEndYear() { return endYear; }
        public void SetEndYear(int value) { endYear = value; }

        public string GetDegreeAwarded() { return degreeAwarded; }
        public void SetDegreeAwarded(string value) { degreeAwarded = value; }

        public int GetCreditsRequired() { return creditsRequired; }
        public void SetCreditsRequired(int value) { creditsRequired = value; }
    }
}
