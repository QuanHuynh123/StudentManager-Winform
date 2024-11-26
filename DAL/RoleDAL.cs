using DAL.Models;
using Dapper;
using DTO.Models;
using DTO;
using System.Collections.Generic;
using System.Linq;

namespace DAL
{
    public class RoleDAL : SqlConnectionData
    {
        public SearchResponse<RoleDTO> Search(SearchRequest request)
        {
            string keyWord = !string.IsNullOrWhiteSpace(request.KeyWord) ? request.KeyWord.ToLower() : "";
            string query = @"Select * from role 
                            order by RoleID offset @Offset rows fetch next @Limit rows only";

            string queryNumberOfRecord = @"Select count(*) from role";

            using (var connection = Connection())
            {
                connection.Open();

                List<RoleDTO> foundRoles = connection.Query<RoleDTO>(
                    query,
                    new
                    {
                        Offset = request.PageSize * request.PageIndex,
                        Limit = request.PageSize
                    }
                ).ToList();

                int numberOfRecord = connection.QueryFirst<int>(
                     queryNumberOfRecord
                 );

                if (foundRoles.Count > 0)
                {
                    return new SearchResponse<RoleDTO>
                    {
                        Data = foundRoles,
                        TotalRecord = numberOfRecord
                    };
                }

                return new SearchResponse<RoleDTO>
                {
                    Data = foundRoles,
                    TotalRecord = numberOfRecord
                };
            }
        }
    }
}
