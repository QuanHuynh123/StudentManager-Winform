using Dapper;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
