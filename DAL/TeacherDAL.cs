using System;
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
                    command.Parameters.AddWithValue("@Username", account.GetUsername());
                    command.Parameters.AddWithValue("@Password", PasswordHasher.HashPassword(account.GetPassword()));

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
                string query = "SELECT TeacherID,FullName,  Gender, Email, PhoneNumber, Status, DepartmentID FROM Teacher WHERE Username = @Username";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            TeacherDTO teacher = new TeacherDTO();
                            teacher.SetTeacherID((int)reader["TeacherID"]);
                            teacher.SetFullName((string)reader["FullName"]);
                            teacher.SetGender((bool)reader["Gender"]);
                            teacher.SetEmail((string)reader["Email"]);
                            teacher.SetPhoneNumber((string)reader["PhoneNumber"]);
                            teacher.SetStatus((bool)reader["Status"]);
                            teacher.SetDepartmentID((int)reader["DepartmentID"]);

                            return teacher;
                        }
                    }
                }
            }
            return null; // Nếu không tìm thấy giáo viên
        }
    }
}
