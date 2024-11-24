using DAL;
using DAL.Models;
using DTO;
using DTO.Models;
using System;

namespace BLL
{
    public class SubjectBLL
    {
        private SubjectDAL subjectDAL;

        public SubjectBLL()
        {
            subjectDAL = new SubjectDAL();
        }

        public SearchResponse<SubjectDTO> Search(SearchRequest request)
        {
            try
            {
                return subjectDAL.Search(request);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi tìm kiếm: {ex.Message}");
                return new SearchResponse<SubjectDTO>();
            }
        }
    }
}
