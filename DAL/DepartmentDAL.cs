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
                            department.SetHeadOfDepartment((string)reader["HeadOfDepartment"]);
                            department.SetEmail((string)reader["Email"]);
                            department.SetEstablishedYear((int)reader["EstablishedYear"]);

                            departments.Add(department);
                        }
                    }
                }
                // Kết nối sẽ tự động đóng khi sử dụng `using`
            }
            return departments;
        }
    }
}
