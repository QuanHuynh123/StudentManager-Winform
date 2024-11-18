using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using DTO;

namespace DAL
{
    public class TeacherDAL : SqlConnectionData
    {
        // Phương thức kiểm tra mật khẩu giáo viên
        public bool CheckTeacherPassword(AccountDTO account)
        {
            using (var connection = Connection())
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM Teacher WHERE Username = @Username AND Password = @Password";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Thêm tham số để tránh SQL Injection
                    command.Parameters.AddWithValue("@Username", account.Username);
                    command.Parameters.AddWithValue("@Password", PasswordHasher.HashPassword(account.Password));

                    int count = (int)command.ExecuteScalar(); // Trả về số lượng bản ghi tìm thấy

                    // Nếu có ít nhất một bản ghi thì mật khẩu là chính xác
                    return count > 0;
                }
            }
        }

        // Phương thức lấy thông tin giáo viên
        public TeacherDTO GetTeacherInfo(string username)
        {
            using (var connection = Connection())
            {
                connection.Open();
                string query = "SELECT TeacherID,FullName,  Gender, Email, PhoneNumber, Status, DepartmentID , RoleID FROM Teacher WHERE Username = @Username";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            TeacherDTO teacher = new TeacherDTO();
                            teacher.TeacherID = (int)reader["TeacherID"];
                            teacher.FullName = (string)reader["FullName"];
                            teacher.Gender = (bool)reader["Gender"];
                            teacher.Email = (string)reader["Email"];
                            teacher.PhoneNumber = (string)reader["PhoneNumber"];
                            teacher.Status = (bool)reader["Status"];
                            teacher.DepartmentID = (int)reader["DepartmentID"];
                            teacher.RoleID = (int)reader["RoleID"];

                            return teacher;
                        }
                    }
                }
            }
            return null; // Nếu không tìm thấy giáo viên
        }

        public List<TeacherDTO> GetTeachersForHeadOfDepartment()
        {
            List<TeacherDTO> teachers = new List<TeacherDTO>();

            using (var connection = Connection())
            {
                connection.Open();
                string query = "SELECT TeacherID, FullName FROM Teacher WHERE RoleID = 1 AND Status = 1";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            TeacherDTO teacher = new TeacherDTO();
                            teacher.TeacherID = (int)reader["TeacherID"];
                            teacher.FullName = (string)reader["FullName"];

                            teachers.Add(teacher);
                        }
                    }
                }
            }

            return teachers;
        }

        public bool UpdateTeacherRole(int teacherID, int newRoleID)
        {
            using (var connection = Connection())
            {
                connection.Open();
                string query = "UPDATE Teacher SET RoleID = @RoleID WHERE TeacherID = @TeacherID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@TeacherID", teacherID);
                    command.Parameters.AddWithValue("@RoleID", newRoleID);

                    int rowsAffected = command.ExecuteNonQuery(); // Execute the update query

                    // Return true if the update was successful (i.e., rows were affected)
                    return rowsAffected > 0;
                }
            }
        }

    }
}
