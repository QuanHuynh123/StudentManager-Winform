using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace BLL
{
    public class DepartmentBLL
    {
        private DepartmentDAL departmentDAL;

        public DepartmentBLL()
        {
            departmentDAL = new DepartmentDAL();
        }

        // Lấy tất cả các Department
        public List<DepartmentDTO> GetAllDepartments()
        {
            return departmentDAL.GetAllDepartments();
        }

        public List<DepartmentDTO> GetDepartmentsOfTeacher()
        {
            try
            {
                int roleID = SessionLogin.LoggedInTeacher.RoleID;
                int departmentID = SessionLogin.LoggedInTeacher.DepartmentID;
                var result = departmentDAL.GetAllDepartments();
                if (roleID != Constants.Principal)
                {
                    return result.Where(d => d.DepartmentID == departmentID).ToList();
                }
                return result;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi lấy: {ex.Message}");
                return null;
            }
        }
        // Kiểm tra trùng tên khoa
        public bool CheckValidName(string departmentName)
        {
            bool result = true;
            List<DepartmentDTO> departments = departmentDAL.GetAllDepartments();
            foreach (var item in departments)
            {
                if (string.Equals(departmentName, item.DepartmentName, StringComparison.OrdinalIgnoreCase))
                {
                    result = false;
                }
            }
            return result;
        }
        public bool CheckExistedDepartment(int departmentID)
        {
            bool result = true;
            List<DepartmentDTO> departments = departmentDAL.GetAllDepartments();
            foreach (var item in departments)
            {
                if (string.Equals(departmentID.ToString(), item.DepartmentID.ToString(), StringComparison.OrdinalIgnoreCase))
                {
                    result = false;
                }
            }
            return result;
        }
        // Thêm Department mới
        public bool AddDepartment(DepartmentDTO department)
        {
            try
            {
                // Kiểm tra trước khi thêm vào cơ sở dữ liệu
                if (string.IsNullOrEmpty(department.DepartmentName))
                    return false;
                if (!CheckValidName(department.DepartmentName))
                {
                    return false;
                }
                return departmentDAL.AddDepartment(department);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi thêm Department: {ex.Message}");
                return false;
            }
        }

        // Cập nhật thông tin Department
        public bool UpdateDepartment(DepartmentDTO department)
        {
            try
            {
                // Kiểm tra trước khi cập nhật
                if (department.DepartmentID <= 0 || string.IsNullOrEmpty(department.DepartmentName))
                    return false;

                return departmentDAL.UpdateDepartment(department);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi cập nhật Department: {ex.Message}");
                return false;
            }
        }

        // Xóa Department
        public bool DeleteDepartment(int departmentID)
        {
            try
            {
                if (departmentID <= 0)
                    return false;
                return departmentDAL.DeleteDepartment(departmentID);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi xóa Department: {ex.Message}");
                return false;
            }
        }

        // Tìm kiếm Department theo tên
        public List<DepartmentDTO> SearchDepartments(string searchQuery)
        {
            try
            {
                if (string.IsNullOrEmpty(searchQuery))
                    return new List<DepartmentDTO>();

                return departmentDAL.SearchDepartments(searchQuery);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi tìm kiếm Department: {ex.Message}");
                return new List<DepartmentDTO>();
            }
        }

        public DepartmentDTO findByIdDepartment(int departmentID)
        {
            try
            {
                if (departmentID <= 0)
                    return null;

                return departmentDAL.findByIdDepartment(departmentID);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi tìm Department theo ID: {ex.Message}");
                return null;
            }
        }

        public bool CheckSameDepartmentTeacherForHeadOfDepartment(int teacherId, int departmentId)
        {
            return departmentDAL.CheckSameDepartmentTeacherForHeadOfDepartment(teacherId, departmentId);
        }

        public List<TeacherDTO> getTeacherByDepartmentiD(int departmentId)
        {
            try
            {
                return departmentDAL.getTeacherByDepartmentiD(departmentId);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi tìm kiếm Department: {ex.Message}");
                return new List<TeacherDTO>();
            }
        }

        public bool UpdateTeacherRole(int newHeadOfDepartmentId, int oldHeadOfDepartmentId)
        {
            return departmentDAL.UpdateTeacherRole(newHeadOfDepartmentId, oldHeadOfDepartmentId);
        }
    }
}