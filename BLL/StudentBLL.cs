using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
