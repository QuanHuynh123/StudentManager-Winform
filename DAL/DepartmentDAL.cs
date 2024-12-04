using Dapper;
using DTO;
using System.Collections.Generic;
using System.Linq;

namespace DAL
{
    public class DepartmentDAL : SqlConnectionData
    {
        public List<DepartmentDTO> GetAllDepartments()
        {
            List<DepartmentDTO> departments = new List<DepartmentDTO>();

            using (var connection = Connection())
            {
                connection.Open();
                string query = "SELECT * FROM department d LEFT JOIN teacher t on d.TeacherID = t.TeacherID";
                departments = connection.Query<DepartmentDTO, TeacherDTO, DepartmentDTO>(
                    query, (d, t) =>
                    {
                        d.Teacher = t;
                        return d;
                    }, splitOn: "DepartmentID,TeacherID"
                ).ToList();
            }
            return departments;
        }

        public List<DepartmentDTO> GetDepartmentOfTeacher(int teacherID)
        {
            using (var connection = Connection())
            {
                connection.Open();
                string query = $@"SELECT * FROM department d 
                                    right join teacher t on t.TeacherID = @TeacherID";
                var result = connection.Query<DepartmentDTO>(
                    query,
                    new
                    {
                        TeacherID = teacherID
                    }
                ).ToList();

                return result;
            }
        }

        public bool AddDepartment(DepartmentDTO department)
        {
            using (var connection = Connection())
            {
                connection.Open();
                string query = $@"INSERT INTO Department (DepartmentName, TeacherID, Email, EstablishedYear)
                               VALUES (@DepartmentName, @TeacherID, @Email, @EstablishedYear)";

                int affectedRows = connection.Execute(query, department);

                if(affectedRows <= 0)
                {
                    return false;
                }

                return true;
            }
        }

        public bool DeleteDepartment(int departmentID)
        {
            using (var connection = Connection())
            {
                connection.Open();
                string query = "DELETE FROM Department WHERE DepartmentID = @DepartmentID";

                int rowDeleted = connection.Execute(query, new { DepartmentID  = departmentID });

                if (rowDeleted <= 0)
                {
                    return false;
                }

                return true;
            }
        }

        public bool UpdateDepartment(DepartmentDTO department)
        {
            using (var connection = Connection())
            {
                connection.Open();
                string query = "UPDATE Department SET DepartmentName = @DepartmentName, TeacherID = @TeacherID, " +
                               "Email = @Email, EstablishedYear = @EstablishedYear WHERE DepartmentID = @DepartmentID";

                int rowUpdated = connection.Execute(query, department);

                if (rowUpdated <= 0)
                {
                    return false;
                }

                return true;
            }
        }

        public List<DepartmentDTO> SearchDepartments(string departmentName)
        {
            List<DepartmentDTO> departments = new List<DepartmentDTO>();

            using (var connection = Connection())
            {
                connection.Open();
                string query = "SELECT * FROM Department WHERE DepartmentName LIKE CONCAT('%',N'@DepartmentName','%')";

               departments = connection.Query<DepartmentDTO>(query, new { DepartmentName = departmentName }).ToList();
            }

            return departments;
        }

        public DepartmentDTO findByIdDepartment(int departmentID)
        {
            using (var connection = Connection())
            {
                connection.Open();
                string query = "SELECT * FROM Department WHERE DepartmentID = @DepartmentID";

                // Thực thi truy vấn và lấy kết quả
                DepartmentDTO department = connection.QueryFirstOrDefault<DepartmentDTO>(query, new { DepartmentID = departmentID });

                return department;
            }
        }

    }
}
