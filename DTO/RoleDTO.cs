using System.Collections.Generic;

namespace DTO
{
    public class RoleDTO
    {
        public int RoleID { get; set; }
        public string NameRole { get; set; }
        public string Description { get; set; }
        public List<RoleActivityDTO> RoleActivities { get; set; }
    }
}
