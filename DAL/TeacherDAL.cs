using Dapper;
using DTO;
using System.Collections.Generic;
using System.Linq;

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

                TeacherDTO foundTeacher = connection.QuerySingle<TeacherDTO>(query, new { 
                    Username = account.Username, 
                    Password = PasswordHasher.HashPassword(account.Password) });

                if(foundTeacher == null)
                {
                    return false;
                }

                return true;
            }
        }

        // Phương thức lấy thông tin giáo viên
        public TeacherDTO GetTeacherInfo(string username)
        {
            using (var connection = Connection())
            {
                connection.Open();

                string query = "SELECT TeacherID,FullName,  Gender, Email, PhoneNumber, Status, DepartmentID , RoleID FROM Teacher WHERE Username = @Username";

                TeacherDTO foundTeacher = connection.QuerySingle<TeacherDTO>(query, new { Username = username });

                return foundTeacher;
            }
        }

        // Lấy danh sách giáo viên chưa làm trưởng khoa để đề cử
        public List<TeacherDTO> GetTeachersForHeadOfDepartment()       
        {
            using (var connection = Connection())
            {
                connection.Open();

                string query = "SELECT TeacherID, FullName FROM Teacher WHERE RoleID = 1 AND Status = 1";

                List<TeacherDTO> foundTeachers = (connection.Query<TeacherDTO>(query)).ToList();

                return foundTeachers;
            }
        }

        // Update role của giảng viên thành Trưởng Khoa sau khi đề cử
        public bool UpdateTeacherRole(int teacherID, int newRoleID)
        {
            using (var connection = Connection())
            {
                connection.Open();

                string query = "UPDATE Teacher SET RoleID = @RoleID WHERE TeacherID = @TeacherID";

                var rowsUpdated = connection.Execute(query, new { 
                    RoleID = newRoleID, 
                    TeacherID = teacherID });

                if (rowsUpdated <= 0) {
                    return false;
                }

                return true;
            }
        }

    }
}
