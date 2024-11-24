using DAL.Models;
using Dapper;
using DTO;
using DTO.Models;
using System.Collections.Generic;
using System.Linq;

namespace DAL
{
    public class SubjectDAL : SqlConnectionData
    {
        public SearchResponse<SubjectDTO> Search(SearchRequest request)
        {
            string keyWord = !string.IsNullOrWhiteSpace(request.KeyWord) ? request.KeyWord.ToLower() : "";
            string query = @"Select * from subject 
                            where SubjectName like @SubjectName order by SubjectID offset @Offset rows fetch next @Limit rows only";

            string queryNumberOfRecord = @"Select count(*) from subject where SubjectName like @SubjectName";

            using (var connection = Connection())
            {
                connection.Open();

                List<SubjectDTO> foundTeachers = connection.Query<SubjectDTO>(
                    query,
                    new
                    {
                        SubjectName = $"%{keyWord}%",
                        Offset = request.PageSize * request.PageIndex,
                        Limit = request.PageSize
                    }
                ).ToList();

                int numberOfRecord = connection.QueryFirst<int>(
                     queryNumberOfRecord,
                     new
                     {
                         SubjectName = $"%{keyWord}%",
                     }
                 );

                if (foundTeachers.Count > 0)
                {
                    return new SearchResponse<SubjectDTO>
                    {
                        Data = foundTeachers,
                        TotalRecord = numberOfRecord
                    };
                }

                return new SearchResponse<SubjectDTO>
                {
                    Data = foundTeachers,
                    TotalRecord = numberOfRecord
                };
            }
        }
    }
}
