using Dapper;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class TranscriptDAL : SqlConnectionData 
    {   
        // Lấy bảng điểm của 1 sinh viên
        public List<TranscriptDTO> getTranscriptStudent(int studentID)
        {
            using (var connection = Connection())
            {
                connection.Open();

                string query = "SELECT " +
                    "  t.TranscriptID," +
                    "  t.SubjectID," +
                    "  s.SubjectName," +
                    "  s.Credits," + 
                    "  t.StudentID," +
                    "  t.YearTranscript," +
                    "  t.Status,"+ 
                    "  t.Semester," +
                    "  t.MidtermScore," +
                    "  t.FinalScore," +
                    "  t.TotalScore" +
                    "  FROM Transcript t JOIN Subject s ON t.SubjectID = s.SubjectID" +
                    "  WHERE   t.StudentID = @studentID" +
                    "  ORDER BY   t.YearTranscript DESC, t.Semester ASC";
                List<TranscriptDTO> transcript =  (connection.Query<TranscriptDTO>(query, new { studentID = studentID })).ToList();
                return transcript;
            }
        }
    }
}
