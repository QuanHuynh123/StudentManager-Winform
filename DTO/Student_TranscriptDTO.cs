using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Student_TranscriptDTO
    {
        public int TranscriptID { get; set; }
        public string FullName { get; set; }
        public float MidtermScore { get; set; }
        public float FinalScore { get; set; }
        public float TotalScore { get; set; }
    }
}
