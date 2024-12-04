using BLL;
using DTO;
using System.Data;
using System.Reflection.Emit;

namespace GUI
{
    public partial class Transcript : Form
    {
        private int studentID;
        private TranscriptBLL transcriptBLL;
        int totalCreditsEarned;
        float GPA; 
        public Transcript(int studentId, int totalCreditsEarned, float GPA )
        {
            InitializeComponent();
            this.studentID = studentId;
            this.totalCreditsEarned = totalCreditsEarned; // Sửa lại để gán đúng giá trị
            this.GPA = GPA;
            transcriptBLL  = new TranscriptBLL();
            loadTranscriptStudent(studentId);
        }

        public void loadTranscriptStudent(int studentId)
        {
            TranscriptBLL transcriptBLL = new TranscriptBLL();
            List<TranscriptDTO> transcripts = transcriptBLL.getTranscriptStudent(studentId);

            var yearSemesters = transcripts
              .GroupBy(t => new { t.YearTranscript, t.Semester })
              .OrderBy(g => g.Key.YearTranscript)
              .ThenBy(g => g.Key.Semester);

            tableLayoutPanelTranscript.RowCount = yearSemesters.Count();

            float averageSemester4 = 0, averageSemester10 = 0 , total10 = 0 ,  he10_1Mon = 0  ;
            int total4 = 0 , totalCreditPass = 0 ,  totalCreditSemester =0, he4_1Mon = 0;
            int row = yearSemesters.Count();
            float saveTotalCreditPass = 0 , savehe4SemesterPass = 0  , save10SemesterPass = 0 ;
            float tichluyGPA4 = 0 , tichluyGPA10 = 0;

            foreach (var yearSemester in yearSemesters)
            {
              
                foreach (var transcript in yearSemester)
                {
                    he10_1Mon = transcript.TotalScore * transcript.Credits;  // tính tbm hệ 10
                    total10 += he10_1Mon;                           // tổng các tbm hệ 10 trong 1 kì
                    totalCreditSemester += transcript.Credits;      // tổng tín chỉ đã học trong 1 kì
                    if (transcript.Status)                          // check các môn đạt
                    {
                        savehe4SemesterPass += (EvaluateScoreOnScale4(transcript.TotalScore) * transcript.Credits);  // lưu trước hệ 4 lích lũy đã đạt
                        save10SemesterPass += he10_1Mon;
                        totalCreditPass += transcript.Credits;      // lưu tín chỉ đạt hệ tính hệ 4 tích lũy
                        saveTotalCreditPass += transcript.Credits; // lưu số tín chỉ tích lũy ( phải đạt ) 
                    }
                    he4_1Mon = (EvaluateScoreOnScale4(transcript.TotalScore) * transcript.Credits);  // tính tbm hệ 4
                    total4 += he4_1Mon;    // tổng các tbm hệ 4 trong 1 kì
                }
                averageSemester4 = (float)total4 / (float)totalCreditSemester;
                averageSemester4 = (float)Math.Round(averageSemester4, 2);
                averageSemester10 = total10 / totalCreditSemester;
                tichluyGPA4 = (float)Math.Round(savehe4SemesterPass / saveTotalCreditPass, 2);
                tichluyGPA10 = (float)Math.Round(save10SemesterPass / saveTotalCreditPass, 2);
                AddSemesterPanel(tableLayoutPanelTranscript, yearSemester.ToList(), averageSemester4, averageSemester10, totalCreditPass, row, tichluyGPA4, tichluyGPA10,  saveTotalCreditPass );
                row--;
                averageSemester4 = 0;
                averageSemester10 = 0;
                total10 = 0 ;
                total4 = 0;
                totalCreditSemester = 0;
                totalCreditPass = 0;
            }
        }

        public int EvaluateScoreOnScale4(float totalScore)
        {
            if (totalScore < 4.0)
            {
                return 0;
            }
            else if (totalScore >= 4.0 && totalScore <= 5.4)
            {
                return 1;
            }
            else if (totalScore >= 5.5 && totalScore <= 6.9)
            {
                return 2;
            }
            else if (totalScore >= 7.0 && totalScore <= 8.4)
            {
                return 3;
            }
            else // totalScore >= 8.5
            {
                return 4;
            }
        }

        private void AddSemesterPanel(TableLayoutPanel tableLayoutMain, List<TranscriptDTO> transcripts, float averageSemester4, float averageSemester10, int totalCreditPass, int row, float tichluyGPA4,float tichluyGPA10, float saveTotalCreditPass)
        {
            // Tạo Panel chính cho học kỳ
            var semesterPanel = new Panel
            {
                Height = 300, // Tùy chỉnh chiều cao cho mỗi học kỳ
                BorderStyle = BorderStyle.FixedSingle,
                Dock = DockStyle.Top
            };

            foreach (var transcript in transcripts)
            {

                // Tạo TableLayoutPanel trong panel 1 học kỳ
                var semesterLayout = new TableLayoutPanel
                {
                    Dock = DockStyle.Fill,
                    RowCount = 2,
                    ColumnCount = 1
                };
                semesterLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 70)); // Top: 70%
                semesterLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 30)); // Bottom: 30%

                // Panel Top - Chứa ListView thông tin bảng điểm
                var panelTop = new TableLayoutPanel
                {
                    Dock = DockStyle.Fill,
                    RowCount = 2,
                    ColumnCount = 1
                };
                var labelSemester = new System.Windows.Forms.Label { Text = $"Học kỳ {transcript.Semester} - {transcript.YearTranscript}", Dock = DockStyle.Fill };
                var listView = CreateListView(transcripts);
                panelTop.RowStyles.Add(new RowStyle(SizeType.Percent, 20)); // Top: 20%
                panelTop.RowStyles.Add(new RowStyle(SizeType.Percent, 80)); // Bottom: 80%
                panelTop.Controls.Add(labelSemester,0,0);
                panelTop.Controls.Add(listView,0,1);


                // Panel Bottom - Chứa thông tin tóm tắt kết quả bảng điểm
                var panelBottom = new TableLayoutPanel
                {
                    Dock = DockStyle.Fill,
                    Padding = new Padding(10),
                    RowCount = 3,
                    ColumnCount = 2,
                    BackColor = Color.DarkBlue
                };
                // Thêm các label thông tin điêm vào panelBottom
                var labelGPA4 = new System.Windows.Forms.Label { Text = $"Điểm trung bình lũy hệ 4 : {tichluyGPA4}", Dock = DockStyle.Top , ForeColor = Color.White };
                var labelAverageSemester4 = new System.Windows.Forms.Label { Text = $"Điểm trung bình học kỳ hệ 4 : {averageSemester4}", Dock = DockStyle.Top , ForeColor = Color.White };
                var labelAverageSemester10 = new System.Windows.Forms.Label { Text = $"Điểm trung bình học kỳ hệ 10 : {averageSemester10}", Dock = DockStyle.Top , ForeColor = Color.White };
                var labelTotalCredits = new System.Windows.Forms.Label { Text = $"Tổng số tín chỉ tích lũy :{saveTotalCreditPass}", Dock = DockStyle.Top , ForeColor = Color.White };
                var labelTotalCreditSemester = new System.Windows.Forms.Label { Text = $"Tín chỉ đạt : {totalCreditPass}", Dock = DockStyle.Top , ForeColor = Color.White };
                var labelGPA10 = new System.Windows.Forms.Label { Text = $"Điểm trung bình lũy hệ 10 :{tichluyGPA10}", Dock = DockStyle.Top, ForeColor = Color.White };
                panelBottom.RowStyles.Add(new RowStyle(SizeType.Percent, 33)); 
                panelBottom.RowStyles.Add(new RowStyle(SizeType.Percent, 33)); 
                panelBottom.RowStyles.Add(new RowStyle(SizeType.Percent, 33)); 
                panelBottom.ColumnStyles.Add(new ColumnStyle(SizeType.Percent,50));
                panelBottom.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50));

                panelBottom.Controls.Add(labelAverageSemester4, 0 , 0 );
                panelBottom.Controls.Add(labelAverageSemester10, 0 , 1 );
                panelBottom.Controls.Add(labelTotalCreditSemester,0,2);
                panelBottom.Controls.Add(labelGPA4, 1, 0);
                panelBottom.Controls.Add(labelGPA10, 1, 1);
                panelBottom.Controls.Add(labelTotalCredits,1,2);
               

                // Thêm các panel con vào TableLayoutPanel
                semesterLayout.Controls.Add(panelTop, 0, 0);
                semesterLayout.Controls.Add(panelBottom, 0, 1);

                // Thêm layout này vào panel chính của học kỳ
                semesterPanel.Controls.Add(semesterLayout);
            }
            // Thêm panel này vào TableLayoutPanel chính
            tableLayoutMain.Controls.Add(semesterPanel, 0, row);
        }

        private ListView CreateListView(List<TranscriptDTO> transcripts)
        {
            var listView = new ListView
            {
                Dock = DockStyle.Fill,
                View = View.Details,
                FullRowSelect = true
            };

            // Thêm các cột
            listView.Columns.Add("ID", 50);
            listView.Columns.Add("Mã môn học", 100);
            listView.Columns.Add("Tên môn học", 200);
            listView.Columns.Add("Số tín chỉ", 100);
            listView.Columns.Add("Điểm giữa kỳ", 100);
            listView.Columns.Add("Điểm cuối kỳ", 100);
            listView.Columns.Add("Điểm tổng kết", 100);
            listView.Columns.Add("Kết quả", 100);

            int index = 1; 
            // Thêm dữ liệu
            foreach (var transcript in transcripts)
            {
                var item = new ListViewItem(index.ToString());
                item.SubItems.Add(transcript.SubjectID.ToString());
                item.SubItems.Add(transcript.SubjectName.ToString());
                item.SubItems.Add(transcript.Credits.ToString());
                item.SubItems.Add(transcript.MidtermScore.ToString());
                item.SubItems.Add(transcript.FinalScore.ToString());
                item.SubItems.Add(transcript.TotalScore.ToString());
                if (transcript.Status)
                    item.SubItems.Add("Đạt");
                else item.SubItems.Add("Chưa đạt");
                listView.Items.Add(item);
            }

            return listView;
        }



    }
}
