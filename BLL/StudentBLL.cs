using DAL;
using DTO;

namespace BLL
{
    public class StudentBLL
    {
        private StudentDAL studentDAL;
        public StudentBLL()
        {
            studentDAL = new StudentDAL();
        }

        public StudentDTO getStudentInfo(int studentID)
        {
            return studentDAL.getStudentInfo(studentID);
        }
    }
}
