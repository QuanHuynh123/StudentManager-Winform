using DAL;
using DTO;
using System.Collections.Generic;

namespace BLL
{
    public class TranscriptBLL
    {
        private TranscriptDAL transcriptDAL;

        public TranscriptBLL()
        {
            transcriptDAL = new TranscriptDAL();
        }

        public List<TranscriptDTO> getTranscriptStudent(int studentID)
        {
            return transcriptDAL.getTranscriptStudent(studentID);
        }
    }
}
