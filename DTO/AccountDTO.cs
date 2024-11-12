using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class AccountDTO
    {
        private string username;
        private string password;

        public string GetUsername() { return username; }
        public void SetUsername(string value) { username = value; }

        public string GetPassword() { return password; }
        public void SetPassword(string value) { password = value; }
    }
}
