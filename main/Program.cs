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
            AccountDTO accountDTO = new AccountDTO();
            accountDTO.SetUsername("thuyloansgu");
            accountDTO.SetPassword("123");


            // Khởi tạo TeacherDAL
            TeacherDAL teacherDAL = new TeacherDAL();

            // Kiểm tra thông tin đăng nhập
            bool isAuthenticated = teacherDAL.CheckTeacherPassword(accountDTO);
            Console.WriteLine("heloooooooooo" + isAuthenticated);

        }
    }
}
