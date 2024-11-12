using System;
using DAL;
using DTO;

namespace BLL
{
    internal class TeacherBLL
    {
        private TeacherDAL teacherDAL;

        public TeacherBLL()
        {
            teacherDAL = new TeacherDAL();
        }

        // Phương thức kiểm tra tài khoản giáo viên
        public Boolean ValidateTeacher(AccountDTO account)
        {
            if (teacherDAL.CheckTeacherPassword(account))
            {
                return true;
            }
            return false;
        }

        public TeacherDTO getInforTeacher(AccountDTO account)
        {
            return teacherDAL.GetTeacherInfo(account.GetUsername());
        }

    }
}
