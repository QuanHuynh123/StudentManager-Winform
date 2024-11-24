using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

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
