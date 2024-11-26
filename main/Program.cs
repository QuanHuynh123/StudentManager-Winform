using DTO;
using BLL;
using System;
using System.Collections.Generic;
using DAL;
using System.Security.Principal;

namespace YourNamespace // Thay YourNamespace bằng namespace của bạn
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentBLL studentBLL = new StudentBLL();
            List<StudentDTO> studentDTO = studentBLL.GetStudentByIdDeparment(1);

            Console.WriteLine(studentDTO[1].FullName);

        }
    }
}
