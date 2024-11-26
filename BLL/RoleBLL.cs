using DAL;
using DAL.Models;
using DTO;
using DTO.Models;
using System;
using System.Linq;

namespace BLL
{
    public class RoleBLL
    {
        private readonly RoleDAL roleDAL;
        public RoleBLL() {
            roleDAL = new RoleDAL();
        }

        public SearchResponse<RoleDTO>Search(SearchRequest request)
        {
            try
            {
                int roleID = SessionLogin.LoggedInTeacher.RoleID;
                if (roleID == Constants.Principal)
                {
                    return roleDAL.Search(request);
                }
                var response = roleDAL.Search(request);
                response.Data = response.Data.Where(r => r.RoleID != Constants.Principal).ToList();

                return response;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi tìm kiếm: {ex.Message}");
                return new SearchResponse<RoleDTO>();
            }
        }
    }
}
