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
                string query = "SELECT * FROM Department";
                departments = connection.Query<DepartmentDTO>(query).ToList();
            }
            return departments;
        }

        public bool AddDepartment(DepartmentDTO department)
        {
            using (var connection = Connection())
            {
                connection.Open();
                string query = "INSERT INTO Department (DepartmentName, HeadOfDepartment, Email, EstablishedYear) " +
                               "VALUES (@DepartmentName, @HeadOfDepartment, @Email, @EstablishedYear)";

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
                string query = "UPDATE Department SET DepartmentName = @DepartmentName, HeadOfDepartment = @HeadOfDepartment, " +
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
                string query = "SELECT * FROM Department WHERE DepartmentName LIKE %@DepartmentName%";

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
