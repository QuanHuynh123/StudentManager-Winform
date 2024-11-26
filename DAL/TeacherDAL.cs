using DAL.Models;
using Dapper;
using DTO;
using DTO.Models;
using System.Collections.Generic;
using System.Linq;

namespace DAL
{
    public class TeacherDAL : SqlConnectionData
    {
        public TeacherDTO GetUserSession(AccountDTO account)
        {
            using (var connection = Connection())
            {
                connection.Open();

                string query = @"SELECT *
                                FROM teacher t
                                JOIN (
                                    SELECT r.RoleID, r.NameRole, r.Description, ra.RoleActivityID, ra.ActivityName, ra.Feature  
                                    FROM [Role] r
                                    left JOIN Role_Activity ra ON r.RoleID = ra.RoleID
                                ) AS ra ON t.RoleID = ra.RoleID
                                WHERE t.Username = @Username 
                                  AND t.Password = @Password";

                var teacherDictionary = new Dictionary<int, TeacherDTO>();

                var foundTeacher = connection.Query<TeacherDTO, RoleDTO, RoleActivityDTO, TeacherDTO>(
                    query,
                    (t, r, ra) =>
                    {
                        if (!teacherDictionary.TryGetValue(t.TeacherID, out var currentTeacher))
                        {
                            currentTeacher = t;
                            currentTeacher.Role = r;
                            currentTeacher.Role.RoleActivities = new List<RoleActivityDTO>();

                            teacherDictionary.Add(currentTeacher.TeacherID, currentTeacher);
                        }

                        if (ra != null)
                        {
                            currentTeacher.Role.RoleActivities.Add(ra);
                        }

                        return currentTeacher;
                    },
                    new
                    {
                        Username = account.Username,
                        Password = PasswordHasher.HashPassword(account.Password)
                    },
                    splitOn: "RoleID,RoleActivityID"
                ).FirstOrDefault();

                return foundTeacher;
            }
        }

        public SearchResponse<TeacherDTO> Search(SearchRequest request, int departmentID = 0)
        {
            string keyWord = !string.IsNullOrWhiteSpace(request.KeyWord) ? request.KeyWord.ToLower() : "";
            string query = $@"Select * from teacher 
                                left join role on teacher.RoleID = role.RoleID 
                            where FullName like @FullName 
                                {(departmentID != 0 ? $" and teacher.DepartmentID = {departmentID}" : "")} 
                            order by TeacherID offset @Offset rows fetch next @Limit rows only";

            string queryNumberOfRecord = $@"Select count(*) from teacher
                                                left join role on teacher.RoleID = role.RoleID
                                                {(departmentID != 0 ? $" and teacher.DepartmentID = {departmentID}" : "")} 
                                           where FullName like @FullName";

            using (var connection = Connection())
            {
                connection.Open();

                List<TeacherDTO> foundTeachers = connection.Query<TeacherDTO, RoleDTO, TeacherDTO>(
                    query, (t, r) => {
                        t.Role = r;
                        return t;
                    }, new
                    {
                        FullName = $"%{keyWord}%",
                        Offset = request.PageSize * request.PageIndex,
                        Limit = request.PageSize
                    }, splitOn: "TeacherID,RoleID"
                ).ToList();

                int numberOfRecord = connection.QueryFirst<int>(
                     queryNumberOfRecord,
                     new
                     {
                         FullName = $"%{keyWord}%",
                     }
                 );

                if (foundTeachers.Count > 0)
                {
                    return new SearchResponse<TeacherDTO>
                    {
                        Data = foundTeachers,
                        TotalRecord = numberOfRecord
                    };
                }

                return new SearchResponse<TeacherDTO>
                {
                    Data = foundTeachers,
                    TotalRecord = numberOfRecord
                };
            }
        }

        public bool Create(TeacherDTO teacherDTO)
        {
            string query = @"Insert into teacher (FullName, Gender, Email, PhoneNumber, Status, DepartmentID, Username, Password, RoleID) 
                            Values (@FullName, @Gender, @Email, @PhoneNumber, @Status, @DepartmentID, @Username, @Password, @RoleID)";
            using(var connection = Connection())
            {
                int affectedRows = connection.Execute(query, teacherDTO);

                if (affectedRows <= 0)
                {
                    return false;
                }

                return true;
            }
        }

        public bool Delete(int teacherID)
        {
            using (var connection = Connection())
            {
                connection.Open();
                string query = "DELETE FROM teacher WHERE TeacherID = @TeacherID";

                int rowDeleted = connection.Execute(query, new { TeacherID = teacherID });

                if (rowDeleted <= 0)
                {
                    return false;
                }

                return true;
            }
        }

        public bool Update(TeacherDTO teacherDTO)
        {
            using (var connection = Connection())
            {
                connection.Open();
                string query = @"UPDATE teacher SET FullName = @FullName, 
                                    Gender = @Gender, 
                                    Email = @Email, 
                                    PhoneNumber = @PhoneNumber, 
                                    Status = @Status, 
                                    DepartmentID = @DepartmentID,
                                    Username = @Username,
                                    Password = @Password,
                                    RoleID = @RoleID
                                WHERE TeacherID = @TeacherID";

                int rowUpdated = connection.Execute(query, teacherDTO);

                if (rowUpdated <= 0)
                {
                    return false;
                }

                return true;
            }
        }

        public SearchResponse<TeacherDTO> SearchTeacherInDepartment(SearchRequest request, int departmentID)
        {
            string query = @"Select * from teacher
                                left join department on teacher.DepartmentID = department.DepartmentID
                                left join role on teacher.RoleID = role.RoleID 
                            where teacher.DepartmentID = @DepartmentID order by teacher.TeacherID offset @Offset rows fetch next @Limit rows only";

            string queryNumberOfRecord = @"Select count(*) from teacher
                                              left join department on teacher.DepartmentID = department.DepartmentID
                                              left join role on teacher.RoleID = role.RoleID 
                                           where teacher.DepartmentID = @DepartmentID";

            using (var connection = Connection())
            {
                connection.Open();

                List<TeacherDTO> foundTeachers = connection.Query<TeacherDTO, DepartmentDTO, RoleDTO, TeacherDTO>(
                    query, (t, d, r) => {
                        t.Department = d;
                        t.Role = r;
                        return t;
                    }, new
                    {
                        DepartmentID = departmentID,
                        Offset = request.PageSize * request.PageIndex,
                        Limit = request.PageSize
                    }, splitOn: "TeacherID,DepartmentID,RoleID"
                ).ToList();

                int numberOfRecord = connection.QueryFirst<int>(
                   queryNumberOfRecord,
                   new
                   {
                       DepartmentID = departmentID
                   }
               );

                if (foundTeachers.Count > 0)
                {
                    return new SearchResponse<TeacherDTO>
                    {
                        Data = foundTeachers,
                        TotalRecord = numberOfRecord
                    };
                }

                return new SearchResponse<TeacherDTO>
                {
                    Data = foundTeachers,
                    TotalRecord = numberOfRecord
                };
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

        public bool UpdateTeacherInfo(TeacherDTO updatedTeacher)
        {
            using (var connection = Connection())
            {
                connection.Open();

                string query = @"
            UPDATE Teacher
            SET 
                FullName = @FullName,
                Gender = @Gender,
                Email = @Email,
                PhoneNumber = @PhoneNumber,
            WHERE 
                TeacherID = @TeacherID";

                var rowsUpdated = connection.Execute(query, new
                {
                    FullName = updatedTeacher.FullName,
                    Gender = updatedTeacher.Gender,
                    Email = updatedTeacher.Email,
                    PhoneNumber = updatedTeacher.PhoneNumber,
                    DepartmentID = updatedTeacher.DepartmentID,
                    TeacherID = updatedTeacher.TeacherID
                });

                return rowsUpdated > 0; // Trả về true nếu cập nhật thành công
            }
        }

    }
}
