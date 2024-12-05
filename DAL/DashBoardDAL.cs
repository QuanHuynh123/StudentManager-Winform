using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DashBoardDAL : SqlConnectionData
    {
        // Lấy tổng số lượng sinh viên
        public int GetTotalStudents()
        {
            using (var connection = Connection())
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM Student";
                int totalStudents = connection.ExecuteScalar<int>(query);
                return totalStudents;
            }
        }

        // Lấy tổng số lượng môn học
        public int GetTotalSubjects()
        {
            using (var connection = Connection())
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM Subject";
                int totalSubjects = connection.ExecuteScalar<int>(query);
                return totalSubjects;
            }
        }

        // Lấy tổng số lượng lớp học
        public int GetTotalClasses()
        {
            using (var connection = Connection())
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM Class";
                int totalClasses = connection.ExecuteScalar<int>(query);
                return totalClasses;
            }
        }
        public List<(int EnrollmentYear, int StudentCount)> GetEnrollmentStudent()
        {
            using (var connection = Connection())
            {
                connection.Open();
                string query = @"
            SELECT 
                YEAR(EnrollmentDate) AS EnrollmentYear,
                COUNT(StudentID) AS StudentCount
            FROM 
                [Student]
            WHERE 
                YEAR(EnrollmentDate) BETWEEN YEAR(GETDATE()) - 4 AND YEAR(GETDATE())
            GROUP BY 
                YEAR(EnrollmentDate)
            ORDER BY 
                EnrollmentYear ASC;";

                // Truy vấn không sử dụng DepartmentID
                var result = connection.Query<(int EnrollmentYear, int StudentCount)>(query).ToList();
                return result;
            }
        }


        public Dictionary<bool, int> GetPassFailRatioForCurrentYear()
        {
            using (var connection = Connection())
            {
                connection.Open();

                // Truy vấn SQL
                string query = @"
                    DECLARE @CurrentYear INT = YEAR(GETDATE());
                    SELECT 
                        [Status],
                        COUNT(*) AS Count
                    FROM 
                        [Transcript]
                    WHERE 
                        YearTranscript = @CurrentYear
                    GROUP BY 
                        [Status];";

                // Sử dụng Dapper để thực hiện truy vấn
                var result = connection.Query<(bool Status, int Count)>(query).ToDictionary(x => x.Status, x => x.Count);
                return result;
            }
        }

    }
}
