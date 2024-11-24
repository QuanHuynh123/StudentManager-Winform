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
        public int YearTranscript { get; set; }
        public bool Status { get; set; }

        public string SubjectName { get; set; }
        public int Credits {  get; set; }
    }
}
