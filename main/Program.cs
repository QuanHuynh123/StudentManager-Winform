using DTO;
using BLL;
using System;
using System.Collections.Generic;

namespace YourNamespace // Thay YourNamespace bằng namespace của bạn
{
    class Program
    {
        static void Main(string[] args)
        {
            AccountDTO accountDTO = new AccountDTO();
            accountDTO.SetUsername("quan");
            accountDTO.SetPassword("password");

            TeacherBLL teacgerBLL = new BLL.TeacherBLL();

        }
    }
}
