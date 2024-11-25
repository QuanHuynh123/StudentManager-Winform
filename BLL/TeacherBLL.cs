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
                return teacherDAL.Search(request);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi tìm kiếm: {ex.Message}");
                return new SearchResponse<TeacherDTO>();
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
