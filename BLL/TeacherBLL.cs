using System;
using System.Collections.Generic;
using DAL;
using DTO;

namespace BLL
{
    public class TeacherBLL
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

        public TeacherDTO getInforTeacher(String username)
        {
            return teacherDAL.GetTeacherInfo(username);
        }

        public List<TeacherDTO> getTeacherForHeadOfDepartment()
        {
            return teacherDAL.GetTeachersForHeadOfDepartment();
        }

        public bool ChangeTeacherRoleToHeadOfDepartment(int teacherID)
        {
            return teacherDAL.UpdateTeacherRole(teacherID, 3);
        }

    }
}
