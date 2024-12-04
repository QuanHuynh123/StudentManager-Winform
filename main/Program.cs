using DTO;
using BLL;
using System;
using System.Collections.Generic;
using DAL;
using System.Security.Principal;

namespace YourNamespace // Thay YourNamespace bằng namespace của bạn
{
    class Program
    {
        static void Main(string[] args)
        {
            TranscriptBLL transcriptBLL = new TranscriptBLL();
            List<TranscriptDTO> transcripts = transcriptBLL.getTranscriptStudent(8);

            var yearSemesters = transcripts
              .GroupBy(t => new { t.YearTranscript, t.Semester })
              .OrderBy(g => g.Key.YearTranscript)
              .ThenBy(g => g.Key.Semester);
            foreach (var yearSemester in yearSemesters)
            {
                foreach (var transcript in yearSemester)
                {
                    Console.WriteLine(transcript.YearTranscript   + " /  "  + transcript.Semester +  " / "+ transcript.SubjectName );
                }
            }
        }
    }
}
