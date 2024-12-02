using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class DashBoardBLL
    {
        private readonly DashBoardDAL _dashBoardDAL;

        public DashBoardBLL()
        {
            _dashBoardDAL = new DashBoardDAL();
        }

        // Lấy tổng số lượng sinh viên
        public int GetTotalStudents()
        {
            return _dashBoardDAL.GetTotalStudents();
        }

        // Lấy tổng số lượng môn học
        public int GetTotalSubjects()
        {
            return _dashBoardDAL.GetTotalSubjects();
        }

        // Lấy tổng số lượng lớp học
        public int GetTotalClasses()
        {
            return _dashBoardDAL.GetTotalClasses();
        }

        public List<(int EnrollmentYear, int StudentCount)> GetEnrollmentDataByDepartment(int departmentId)
        {
            return _dashBoardDAL.GetEnrollmentDataByDepartment(departmentId);
        }

        public Dictionary<bool, int> GetPassFailRatioForCurrentYear()
        {
            return _dashBoardDAL.GetPassFailRatioForCurrentYear();
        }

    }
}
