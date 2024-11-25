using Dapper;
using DTO;
using System.Collections.Generic;
using System.Linq;

namespace DAL
{
    public class TrainingProgramDAL : SqlConnectionData
    {
        // Lấy tất cả TrainingProgram
        public List<TrainingProgramDTO> GetAllTrainingPrograms()
        {
            List<TrainingProgramDTO> trainingPrograms = new List<TrainingProgramDTO>();

            using (var connection = Connection())
            {
                connection.Open();
                string query = "SELECT * FROM TrainingProgram";
                trainingPrograms = connection.Query<TrainingProgramDTO>(query).ToList();
            }
            return trainingPrograms;
        }

        // Thêm TrainingProgram
        public bool AddTrainingProgram(TrainingProgramDTO trainingProgram)
        {
            using (var connection = Connection())
            {
                connection.Open();
                string query = "INSERT INTO TrainingProgram (ProgramName, DepartmentID, Duration, StartYear, EndYear, DegreeAwarded, CreditsRequired) " +
                               "VALUES (@ProgramName, @DepartmentID, @Duration, @StartYear, @EndYear, @DegreeAwarded, @CreditsRequired)";

                int affectedRows = connection.Execute(query, trainingProgram);

                return affectedRows > 0;
            }
        }

        // Xóa TrainingProgram
        public bool DeleteTrainingProgram(int programID)
        {
            using (var connection = Connection())
            {
                connection.Open();
                string query = "DELETE FROM TrainingProgram WHERE ProgramID = @ProgramID";

                int rowDeleted = connection.Execute(query, new { ProgramID = programID });

                return rowDeleted > 0;
            }
        }

        // Cập nhật TrainingProgram
        public bool UpdateTrainingProgram(TrainingProgramDTO trainingProgram)
        {
            using (var connection = Connection())
            {
                connection.Open();
                string query = "UPDATE TrainingProgram SET ProgramName = @ProgramName, DepartmentID = @DepartmentID, Duration = @Duration, " +
                               "StartYear = @StartYear, EndYear = @EndYear, DegreeAwarded = @DegreeAwarded, CreditsRequired = @CreditsRequired " +
                               "WHERE ProgramID = @ProgramID";

                int rowUpdated = connection.Execute(query, trainingProgram);

                return rowUpdated > 0;
            }
        }

        // Tìm TrainingProgram theo tên
        public List<TrainingProgramDTO> SearchTrainingPrograms(string programName)
        {
            List<TrainingProgramDTO> trainingPrograms = new List<TrainingProgramDTO>();

            using (var connection = Connection())
            {
                connection.Open();
                string query = "SELECT * FROM TrainingProgram WHERE ProgramName LIKE CONCAT('%', @ProgramName, '%')";

                trainingPrograms = connection.Query<TrainingProgramDTO>(query, new { ProgramName = programName }).ToList();
            }

            return trainingPrograms;
        }

        // Tìm TrainingProgram theo ID
        public TrainingProgramDTO FindByIdTrainingProgram(int programID)
        {
            using (var connection = Connection())
            {
                connection.Open();
                string query = "SELECT * FROM TrainingProgram WHERE ProgramID = @ProgramID";

                TrainingProgramDTO trainingProgram = connection.QueryFirstOrDefault<TrainingProgramDTO>(query, new { ProgramID = programID });

                return trainingProgram;
            }
        }

        public List<TrainingProgramDTO> GetTrainingProgramsByDepartmentID(int departmentID)
        {
            List<TrainingProgramDTO> trainingPrograms = new List<TrainingProgramDTO>();

            using (var connection = Connection())
            {
                connection.Open();
                string query = "SELECT * FROM TrainingProgram WHERE DepartmentID = @DepartmentID";

                trainingPrograms = connection.Query<TrainingProgramDTO>(query, new { DepartmentID = departmentID }).ToList();
            }

            return trainingPrograms;
        }
    }
}
