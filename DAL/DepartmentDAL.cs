using Dapper;
using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Messaging;

namespace DAL
{
    public class DepartmentDAL : SqlConnectionData
    {

        // sql get department list join teacher on teacherID
        // multi-mapping list with query<> return depar, teacher object & depar list
        // spliton split-maps depaID & teacherID columns to corresponding parameter, tolist
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
      
       // return affected row count 
            public bool AddDepartment(DepartmentDTO department)
        {
            using (var connection = Connection())
            {
                connection.Open();
                string query = $@"INSERT INTO Department (DepartmentName, TeacherID, HeadOfDepartment, Email, EstablishedYear)
                               VALUES (@DepartmentName, @TeacherID, @HeadOfDepartment, @Email, @EstablishedYear)";
                int affectedRows = connection.Execute(query, new
                {
                    DepartmentName = department.DepartmentName,
                    TeacherID = department.TeacherID,
                    HeadOfDepartment = department.Teacher.FullName,
                    Email = department.Email,
                    EstablishedYear = department.EstablishedYear,
                });

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
                string query = "UPDATE Department SET DepartmentName = @DepartmentName, TeacherID = @TeacherID, HeadOfDepartment = @HeadOfDepartment, " +
                               "Email = @Email, EstablishedYear = @EstablishedYear WHERE DepartmentID = @DepartmentID";

                int rowUpdated = connection.Execute(query, new
                {
                    DepartmentName = department.DepartmentName,
                    TeacherID = department.TeacherID,
                    HeadOfDepartment = department.Teacher.FullName,
                    Email = department.Email,
                    EstablishedYear = department.EstablishedYear,
                    DepartmentID = department.DepartmentID
                });

                if (rowUpdated <= 0)
                {
                    return false;
                }

                return true;
            }
        }

        public List<DepartmentDTO> SearchDepartments(string searchQuery)
        {
            List<DepartmentDTO> departments = new List<DepartmentDTO>();

            using (var connection = Connection())
            {
                connection.Open();
                string query = "SELECT * FROM department d LEFT JOIN teacher t ON d.TeacherID=t.TeacherID" +
                            " WHERE d.DepartmentName LIKE N'%" + searchQuery + "%'" +
                           " OR t.FullName LIKE N'%" + searchQuery + "%'";
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
