using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public static class SessionLogin
    {
        // Thuộc tính lưu tên người dùng đã đăng nhập
        public static string LoggedInUsername { get; set; }

        // Phương thức kiểm tra xem có đăng nhập hay không
        public static bool IsLoggedIn => !string.IsNullOrEmpty(LoggedInUsername);

        // Phương thức đăng xuất
        public static void Logout()
        {
            LoggedInUsername = null;
        }
    }
}
