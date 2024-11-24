using DAL;
using DTO;
using System;
using System.Collections.Generic;

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

        // Thêm Department mới
        public bool AddDepartment(DepartmentDTO department)
        {
            try
            {
                // Kiểm tra trước khi thêm vào cơ sở dữ liệu
                if (string.IsNullOrEmpty(department.DepartmentName))
                    return false;

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
        public List<DepartmentDTO> SearchDepartments(string departmentName)
        {
            try
            {
                if (string.IsNullOrEmpty(departmentName))
                    return new List<DepartmentDTO>();

                return departmentDAL.SearchDepartments(departmentName);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi tìm kiếm Department: {ex.Message}");
                return new List<DepartmentDTO>();
            }
        }
    }
}
