using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DepartmentDTO
    {
        public int DepartmentID {  get; set; }
        public string DepartmentName { get; set; }
        public string HeadOfDepartment { get; set; }
        public string Email { get; set; }
        public int EstablishedYear { get; set; }
    }
}
