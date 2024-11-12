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

        public List<DepartmentDTO> GetAllDepartments()
        {
            return departmentDAL.GetAllDepartments();
        }

    }
}
