using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class RoleDTO
    {
        private int roleID;
        private string nameRole;
        private string description;

        public int GetRoleID() { return roleID; }
        public void SetRoleID(int value) { roleID = value; }

        public string GetNameRole() { return nameRole; }
        public void SetNameRole(string value) { nameRole = value; }

        public string GetDescription() { return description; }
        public void SetDescription(string value) { description = value; }
    }
}
