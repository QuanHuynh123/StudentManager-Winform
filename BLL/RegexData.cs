using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BLL
{
    public static class RegexData
    {
        public static bool IsValidEmail(string email)
        {
            var emailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            return Regex.IsMatch(email, emailPattern);
        }

        // Hàm kiểm tra định dạng số điện thoại
        public static bool IsValidPhoneNumber(string phoneNumber)
        {
            var phonePattern = @"^\d{10}$";  // Giả sử số điện thoại là 10 chữ số
            return Regex.IsMatch(phoneNumber, phonePattern);
        }
    }
}
