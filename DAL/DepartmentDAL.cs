using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

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
                using (SqlCommand command = new SqlCommand("SELECT * FROM Department", connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var department = new DepartmentDTO();

                            department.SetDepartmentID((int)reader["DepartmentID"]);
                            department.SetDepartmentName((string)reader["DepartmentName"]);
                            department.SetHeadOfDepartment(reader["HeadOfDepartment"] as string);
                            department.SetEmail((string)reader["Email"]);
                            department.SetEstablishedYear(reader["EstablishedYear"] != DBNull.Value
                                           ? (int)reader["EstablishedYear"]
                                           : 0); // Gán giá trị mặc định nếu NULL

                            departments.Add(department);
                        }
                    }
                }
                // Kết nối sẽ tự động đóng khi sử dụng `using`
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

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@DepartmentName", department.GetDepartmentName());
                    command.Parameters.AddWithValue("@HeadOfDepartment", department.GetHeadOfDepartment() ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@Email", department.GetEmail());
                    command.Parameters.AddWithValue("@EstablishedYear", department.GetEstablishedYear());

                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }

        public bool DeleteDepartment(int departmentID)
        {
            using (var connection = Connection())
            {
                connection.Open();
                string query = "DELETE FROM Department WHERE DepartmentID = @DepartmentID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@DepartmentID", departmentID);
                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }

        public bool UpdateDepartment(DepartmentDTO department)
        {
            using (var connection = Connection())
            {
                connection.Open();
                string query = "UPDATE Department SET DepartmentName = @DepartmentName, HeadOfDepartment = @HeadOfDepartment, " +
                               "Email = @Email, EstablishedYear = @EstablishedYear WHERE DepartmentID = @DepartmentID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@DepartmentID", department.GetDepartmentID());
                    command.Parameters.AddWithValue("@DepartmentName", department.GetDepartmentName());
                    command.Parameters.AddWithValue("@HeadOfDepartment", department.GetHeadOfDepartment() ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@Email", department.GetEmail());
                    command.Parameters.AddWithValue("@EstablishedYear", department.GetEstablishedYear());

                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }

        public List<DepartmentDTO> SearchDepartments(string departmentName)
        {
            List<DepartmentDTO> departments = new List<DepartmentDTO>();

            using (var connection = Connection())
            {
                connection.Open();
                string query = "SELECT * FROM Department WHERE DepartmentName LIKE @DepartmentName";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@DepartmentName", "%" + departmentName + "%");

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var department = new DepartmentDTO();
                            department.SetDepartmentID((int)reader["DepartmentID"]);
                            department.SetDepartmentName((string)reader["DepartmentName"]);
                            department.SetHeadOfDepartment(reader["HeadOfDepartment"] as string);
                            department.SetEmail((string)reader["Email"]);
                            department.SetEstablishedYear(reader["EstablishedYear"] != DBNull.Value
                                                           ? (int)reader["EstablishedYear"]
                                                           : 0);

                            departments.Add(department);
                        }
                    }
                }
            }

            return departments;
        }


    }
}
