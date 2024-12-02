using DAL;
using DAL.Models;
using DTO;
using DTO.Models;
using System;

namespace BLL
{
    public class ClassBLL
    {
        private ClassDAL classDAL;
        public ClassBLL() { 
            classDAL = new ClassDAL();
        }

        public SearchResponse<ClassDTO> Search(SearchRequest request)
        {
            try
            {
                int roleID = SessionLogin.LoggedInTeacher.RoleID;
                if (roleID == Constants.INTERN_TEACHER || roleID == Constants.TEACHER) { 
                    return classDAL.Search(request, SessionLogin.LoggedInTeacher.TeacherID);
                }

                if (roleID == Constants.HEAD_OF_DEPARTMENT)
                {
                    return classDAL.Search(request, SessionLogin.LoggedInTeacher.TeacherID, SessionLogin.LoggedInTeacher.DepartmentID);
                }

                return classDAL.Search(request);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi tìm kiếm Class: {ex.Message}");
                return new SearchResponse<ClassDTO>();
            }
        }

        public bool Create_action(ClassDTO classDTO)
        {
            try
            {
                return classDAL.Create(classDTO);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi create Class: {ex.Message}");
                return false;
            }
        }

        public bool Update_action(ClassDTO classDTO)
        {
            try
            {
                return classDAL.Update(classDTO);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi update Class: {ex.Message}");
                return false;
            }
        }

        public bool Delete_action(int classID)
        {
            try
            {
                return classDAL.Delete(classID);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi xóa Class: {ex.Message}");
                return false;
            }
        }

        public ClassDTO getClassById(int classID)
        {
            try
            {
                return classDAL.GetByID(classID);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi xóa Class: {ex.Message}");
                return null;
            }
        }
    }
}
