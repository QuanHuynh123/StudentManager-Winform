using Dapper;
using DTO;

namespace DAL
{
    public class StudentDAL : SqlConnectionData
    {
        public StudentDTO getStudentInfo(int studentID)
        {
            using (var connection = Connection())
            {
                connection.Open();

                string query = "SELECT *FROM Student WHERE StudentID = @studentID";

                StudentDTO student = connection.QuerySingle<StudentDTO>(query, new { studentID = studentID });

                return student;
            }
        }
    }
}
