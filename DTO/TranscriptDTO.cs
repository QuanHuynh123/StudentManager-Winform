using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TranscriptDTO
    {
        private int transcriptID;
        private int studentID;
        private int subjectID;
        private float midtermScore;
        private float finalScore;
        private float totalScore;
        private string semester;

        public int GetTranscriptID() { return transcriptID; }
        public void SetTranscriptID(int value) { transcriptID = value; }

        public int GetStudentID() { return studentID; }
        public void SetStudentID(int value) { studentID = value; }

        public int GetSubjectID() { return subjectID; }
        public void SetSubjectID(int value) { subjectID = value; }

        public float GetMidtermScore() { return midtermScore; }
        public void SetMidtermScore(float value) { midtermScore = value; }

        public float GetFinalScore() { return finalScore; }
        public void SetFinalScore(float value) { finalScore = value; }

        public float GetTotalScore() { return totalScore; }
        public void SetTotalScore(float value) { totalScore = value; }

        public string GetSemester() { return semester; }
        public void SetSemester(string value) { semester = value; }
    }
}
