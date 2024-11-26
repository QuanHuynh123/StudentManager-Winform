using DAL;
using DAL.Models;
using DTO;
using DTO.Models;
using System;
using System.Collections.Generic;

namespace BLL
{
    public class SubjectBLL
    {
        private SubjectDAL subjectDAL;

        public SubjectBLL()
        {
            subjectDAL = new SubjectDAL();
        }

        // Tìm kiếm môn học
        public SearchResponse<SubjectDTO> Search(SearchRequest request)
        {
            try
            {
                return subjectDAL.Search(request);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi tìm kiếm: {ex.Message}");
                return new SearchResponse<SubjectDTO>();
            }
        }

        // Thêm môn học
        public void Add(SubjectDTO subject)
        {
            try
            {
                subjectDAL.Add(subject);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi thêm môn học: {ex.Message}");
            }
        }

        // Xóa môn học
        public void Delete(int subjectId)
        {
            try
            {
                subjectDAL.Delete(subjectId);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi xóa môn học: {ex.Message}");
            }
        }

        // Cập nhật môn học
        public void Update(SubjectDTO subject)
        {
            try
            {
                subjectDAL.Update(subject);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi cập nhật môn học: {ex.Message}");
            }
        }

        // Lấy môn học theo DepartmentID
        public List<SubjectDTO> GetSubjectByDepartmentID(int departmentId)
        {
            try
            {
                return subjectDAL.GetSubjectByDepartmentID(departmentId);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi lấy môn học theo DepartmentID: {ex.Message}");
                return new List<SubjectDTO>();
            }
        }

        public SubjectDTO GetSubjectByID(int subjectId)
        {
            try
            {
                return subjectDAL.GetSubjectByID(subjectId);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi lấy môn học theo DepartmentID: {ex.Message}");
                return null;
            }
        }

        public List<SubjectDTO> GetSubjectByTeacherID(int teacherId)
        {
            try
            {
                return subjectDAL.GetSubjectByTeacherID(teacherId);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi lấy môn học theo teacherID: {ex.Message}");
                return new List<SubjectDTO>();
            }
        }
    }
}
