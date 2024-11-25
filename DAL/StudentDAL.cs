using Dapper;
using DTO;
using System.Collections.Generic;
using System.Linq;

namespace DAL
{
    public class StudentDAL : SqlConnectionData
    {
        public List<StudentDTO> GetStudentFromHomeroom (int teacherID)
        {
            string query = @"Select * from student s
                            where s.StudentID in (
	                            select cs.StudentID from class c 
		                            left join teacher t ON t.TeacherID = c.TeacherID
		                            right join class_Student cs ON c.ClassID = cs.ClassID
	                            where c.SubjectID is Null and c.TeacherID = @TeacherID)";

            using (var connection = Connection())
            {
                connection.Open();

                List<StudentDTO> foundStudents = connection.Query<StudentDTO>(
                    query,
                    new
                    {
                        TeacherID = teacherID
                    }
                ).ToList();

                return foundStudents;
            }
        }

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
