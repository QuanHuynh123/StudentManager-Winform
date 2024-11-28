using DAL;
using DTO;
using System;
using System.Collections.Generic;

namespace BLL
{
    public class StudentBLL
    {
        private StudentDAL studentDAL;
        public StudentBLL()
        {
            studentDAL = new StudentDAL();
        }

        public List<StudentDTO> GetStudentFromHomeroom(int teacherID)
        {
            try
            {
                return studentDAL.GetStudentFromHomeroom(teacherID);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi tìm kiếm: {ex.Message}");
                return new List<StudentDTO>();
            }
        }

        public StudentDTO getStudentInfo(int studentID)
        {
            return studentDAL.getStudentInfo(studentID);
        }

        public List<StudentDTO> GetStudentByIdDepartment(int departmentID)
        {
            try
            {
                return studentDAL.GetStudentByIdDeparment(departmentID);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi tìm kiếm: {ex.Message}");
                return new List<StudentDTO>();
            }
        }

        public bool AddStudent(StudentDTO studentDTO)
        {
            try
            {
                return studentDAL.AddStudent(studentDTO);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi thêm học sinh: {ex.Message}");
                return false;
            }
        }

        public bool DeleteStudent(int studentID)
        {
            try
            {
                return studentDAL.DeleteStudent(studentID);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi xóa học sinh: {ex.Message}");
                return false;
            }
        }

        public bool UpdateStudent(StudentDTO student)
        {
            try
            {
                return studentDAL.UpdateStudent(student);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi cập nhật học sinh: {ex.Message}");
                return false;
            }
        }

        public List<StudentDTO> SearchStudentsByNameOfDepartment(string name, int departmentId)
        {
            try
            {
                return studentDAL.SearchStudentsByNameOfDepartment(name, departmentId);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi tìm kiếm học sinh theo tên: {ex.Message}");
                return new List<StudentDTO>();
            }
        }

        public List<StudentDTO> SearchStudentsByNameOfMyStudent(string name, int teacherId)
        {
            try
            {
                return studentDAL.SearchStudentsByNameOfMyStudent(name, teacherId);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi tìm kiếm học sinh theo tên: {ex.Message}");
                return new List<StudentDTO>();
            }
        }

        public List<ClassDTO> getTimetableStudent(int studentId)
        {
            try
            {
                return studentDAL.getTimetableStudent(studentId);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi tìm kiếm học sinh theo tên: {ex.Message}");
                return new List<ClassDTO>();
            }
        }
    }
}
