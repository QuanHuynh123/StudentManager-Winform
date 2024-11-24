using System.Collections.Generic;

namespace DTO.Models
{
    public class SearchResponse<T>
    {

        public List<T> Data { get; set; } = new List<T>();
        public int TotalRecord { get; set; } = 0;
    }
}
