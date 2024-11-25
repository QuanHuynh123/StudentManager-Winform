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
    }
}
