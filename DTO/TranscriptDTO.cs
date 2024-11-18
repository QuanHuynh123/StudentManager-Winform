using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TranscriptDTO
    {
        public int TranscriptID {  get; set; }
        public int StudentID { get; set; }
        public int SubjectID { get; set; }
        public float MidtermScore { get; set; }
        public float FinalScore { get; set; }
        public float TotalScore { get; set; }
        public string Semester { get; set; }
    }
}
