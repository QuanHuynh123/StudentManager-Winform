using DAL;
using DAL.Models;
using DTO;
using DTO.Models;
using System;
using System.Collections.Generic;

namespace BLL
{
    public class TeacherBLL
    {
        private TeacherDAL teacherDAL;

        public TeacherBLL()
        {
            teacherDAL = new TeacherDAL();
        }

        public TeacherDTO GetUserSession(AccountDTO account) 
        { 
            TeacherDTO foundTeacher = teacherDAL.GetUserSession(account);
            return foundTeacher;
        }

        public SearchResponse<TeacherDTO> Search(SearchRequest request) {
            try
            {
                int roleID = SessionLogin.LoggedInTeacher.RoleID;
                if (roleID == Constants.Principal)
                {
                    return teacherDAL.Search(request);
                }

                return teacherDAL.Search(request, SessionLogin.LoggedInTeacher.DepartmentID);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi tìm kiếm: {ex.Message}");
                return new SearchResponse<TeacherDTO>();
            }
        }

        public SearchResponse<TeacherDTO> SearchTeacherInDepartment(SearchRequest request, int departmentID)
        {
            try
            {
                return teacherDAL.SearchTeacherInDepartment(request, departmentID);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi tìm kiếm: {ex.Message}");
                return new SearchResponse<TeacherDTO>();
            }
        }

        public bool Create(TeacherDTO teacherDTO) {
            try
            {
                teacherDTO.Password = PasswordHasher.HashPassword(teacherDTO.Password);
                return teacherDAL.Create(teacherDTO);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi create: {ex.Message}");
                return false;
            }
        }

        public bool Update(TeacherDTO teacherDTO)
        {
            try
            {
                return teacherDAL.Update(teacherDTO);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi update: {ex.Message}");
                return false;
            }
        }

        public bool Delete(int teacherID)
        {
            try
            {
                return teacherDAL.Delete(teacherID);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi delete: {ex.Message}");
                return false;
            }
        }

        public TeacherDTO GetInforTeacher(String username)
        {
            return teacherDAL.GetTeacherInfo(username);
        }

        public List<TeacherDTO> GetTeacherForHeadOfDepartment()
        {
            return teacherDAL.GetTeachersForHeadOfDepartment();
        }

        public bool ChangeTeacherRoleToHeadOfDepartment(int teacherID)
        {
            return teacherDAL.UpdateTeacherRole(teacherID, 3);
        }

        public bool UpdateTeacher(TeacherDTO updatedTeacher)
        {
            return teacherDAL.UpdateTeacherInfo(updatedTeacher);
        }

    }
}
