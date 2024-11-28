using BLL;
using DTO;

namespace GUI
{
    public partial class Subject : Form
    {
        public SubjectBLL subjectBLL;
        public DepartmentBLL departmentBLL;
        public TrainingProgramBLL trainingProgramBLL;
        public int selectedDepartmentID;
        public int selectedProgramID;
        int subject;
        int selectedCredit;
        public Subject()
        {
            InitializeComponent();
            subjectBLL = new SubjectBLL();
            departmentBLL = new DepartmentBLL();
            trainingProgramBLL = new TrainingProgramBLL();
            loadsubject();
            loadComboboxTrainingProgram();
            loadComboboxDepartment();
            loadComboboxCredit();
        }

        void loadsubject()
        {
            List<SubjectDTO> subjects = subjectBLL.GetSubjectByTeacherID(SessionLogin.LoggedInTeacher.TeacherID);
            listViewSubject.Items.Clear();
            listViewSubject.FullRowSelect = true;
            foreach (SubjectDTO subject in subjects)
            {
                ListViewItem item = new ListViewItem(subject.SubjectID.ToString());
                item.SubItems.Add(subject.SubjectName);
                item.SubItems.Add(subject.Credits.ToString());
                TrainingProgramDTO trainingProgram = trainingProgramBLL.FindByIdTrainingProgram(subject.ProgramID);
                item.SubItems.Add(trainingProgram.ProgramName);
                DepartmentDTO department = departmentBLL.findByIdDepartment(subject.DepartmentID);
                item.SubItems.Add(department.DepartmentName);
                // Thêm item vào ListView
                listViewSubject.Items.Add(item);
            }
        }

        void loadComboboxTrainingProgram()
        {
            comboBox_program.Items.Clear();
            List<TrainingProgramDTO> trainingPrograms = trainingProgramBLL.GetTrainingProgramsByDepartmentID(SessionLogin.LoggedInTeacher.DepartmentID);

            comboBox_program.DisplayMember = "ProgramName";  // Hiển thị tên chương trình
            comboBox_program.ValueMember = "ProgramID";       // Giá trị thực tế là ProgramID

            // Thêm các chương trình vào comboBox
            comboBox_program.DataSource = trainingPrograms;
        }

        void loadComboboxDepartment()
        {
            if (SessionLogin.LoggedInTeacher.RoleID != 4)
            {
                selectedDepartmentID = SessionLogin.LoggedInTeacher.DepartmentID;
                DepartmentDTO department = departmentBLL.findByIdDepartment(SessionLogin.LoggedInTeacher.DepartmentID);
                comboBox_department.Text = department.DepartmentName;
            }
            else
            {
                List<DepartmentDTO> departmentDTO = departmentBLL.GetAllDepartments();
                comboBox_department.Items.Clear(); // Xóa các mục cũ trước khi thêm mới
                foreach (var department in departmentDTO)
                {
                    comboBox_department.Items.Add(department.DepartmentName);
                }
            }
        }

        private void comboBox_program_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedProgramID = (int)comboBox_program.SelectedValue;
        }

        private void comboBox_department_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Lấy DepartmentID từ tên Department
            string selectedDepartmentName = comboBox_department.SelectedItem.ToString();
            var department = departmentBLL.GetAllDepartments()
                                          .FirstOrDefault(d => d.DepartmentName == selectedDepartmentName);

            if (department != null)
            {
                selectedDepartmentID = department.DepartmentID;
            }
        }

        void loadComboboxCredit()
        {
            comboBox_credit.Items.Clear();
            comboBox_credit.Items.Add(1);
            comboBox_credit.Items.Add(2);
            comboBox_credit.Items.Add(4);
            comboBox_credit.SelectedIndex = 0;
        }

        private void comboBox_credit_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedCredit = (int)comboBox_credit.SelectedItem;
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            string subjectName = textBox_subjectName.Text;

            if (string.IsNullOrEmpty(subjectName))
            {
                MessageBox.Show("Vui lòng nhập tên môn học.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var dialogResult = MessageBox.Show("Bạn có chắc muốn thêm môn học này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                SubjectDTO newSubject = new SubjectDTO
                {
                    SubjectName = subjectName,
                    Credits = selectedCredit,
                    ProgramID = selectedProgramID,
                    DepartmentID = selectedDepartmentID
                };

                subjectBLL.Add(newSubject);
                MessageBox.Show("Thêm môn học thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadsubject();
            }

        }

        private void button_update_Click(object sender, EventArgs e)
        {
            if (listViewSubject.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn môn học cần cập nhật.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedItem = listViewSubject.SelectedItems[0];
            int subjectId = int.Parse(selectedItem.SubItems[0].Text);
            string subjectName = textBox_subjectName.Text;

            if (string.IsNullOrEmpty(subjectName))
            {
                MessageBox.Show("Vui lòng nhập tên môn học.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var dialogResult = MessageBox.Show("Bạn có chắc muốn cập nhật môn học này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                SubjectDTO updatedSubject = new SubjectDTO
                {
                    SubjectID = subjectId,
                    SubjectName = subjectName,
                    Credits = selectedCredit,
                    ProgramID = selectedProgramID,
                    DepartmentID = selectedDepartmentID
                };

                subjectBLL.Update(updatedSubject);
                MessageBox.Show("Cập nhật môn học thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadsubject();
            }
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            if (listViewSubject.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn môn học cần xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedItem = listViewSubject.SelectedItems[0];
            int subjectId = int.Parse(selectedItem.SubItems[0].Text);

            var dialogResult = MessageBox.Show("Bạn có chắc muốn xóa môn học này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                subjectBLL.Delete(subjectId);
                MessageBox.Show("Xóa môn học thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadsubject();
            }
        }

        private void listViewSubject_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewSubject.SelectedItems.Count == 0) return;

            var selectedItem = listViewSubject.SelectedItems[0];

            textBox_subjectName.Text = selectedItem.SubItems[1].Text;
            comboBox_credit.SelectedItem = int.Parse(selectedItem.SubItems[2].Text);

            string programName = selectedItem.SubItems[3].Text;
            comboBox_program.SelectedIndex = comboBox_program.FindStringExact(programName);

            string departmentName = selectedItem.SubItems[4].Text;
            comboBox_department.SelectedIndex = comboBox_department.FindStringExact(departmentName);
        }

        private void listViewSubject_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)  // Kiểm tra nếu là click chuột phải
            {
                // Hiển thị MessageBox và chờ người dùng nhấn OK
                DialogResult result = MessageBox.Show("Xem chi tiết", "Thông báo", MessageBoxButtons.OKCancel);

                // Kiểm tra nếu người dùng nhấn OK
                if (result == DialogResult.OK)
                {
                    // Lấy dòng đã chọn
                    ListViewItem selectedItem = listViewSubject.SelectedItems[0];
                    subject = int.Parse(selectedItem.Text);

                    // chuyen tab
                    foreach (TabPage tab in tabControl1.TabPages)
                    {
                        if (tab.Text == "Score")
                        {
                            tabControl1.SelectedTab = tab;
                            loadScore(subject);
                            break;
                        }
                    }
                }
            }
        }

        private void loadScore(int subjectID)
        {
            listView_score.Items.Clear();
            listView_score.FullRowSelect = true;
            List<Student_TranscriptDTO> transcripts = subjectBLL.GetStudentAndTranscriptBySubjectId(subjectID);
            if (transcripts == null || transcripts.Count == 0)
            {
                MessageBox.Show("Lớp không có học sinh nào!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            foreach (Student_TranscriptDTO transcript in transcripts)
            {
                ListViewItem item = new ListViewItem(transcript.TranscriptID.ToString());
                item.SubItems.Add(transcript.FullName);
                item.SubItems.Add(transcript.MidtermScore.ToString("F2")); // Hiển thị điểm với 2 chữ số thập phân
                item.SubItems.Add(transcript.FinalScore.ToString("F2"));
                item.SubItems.Add(transcript.TotalScore.ToString("F2"));
                listView_score.Items.Add(item);
            }
        }

        private void listView_score_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView_score.SelectedItems.Count == 0) return;

            var selectedItem = listView_score.SelectedItems[0];

            // Gán giá trị từ ListView sang các TextBox
            textBox_midterm.Text = selectedItem.SubItems[2].Text;
            textBox_final.Text = selectedItem.SubItems[3].Text;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listView_score.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một học sinh!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedItem = listView_score.SelectedItems[0];
            int transcriptId = int.Parse(selectedItem.SubItems[0].Text);

            if (float.TryParse(textBox_midterm.Text, out float midtermScore) && float.TryParse(textBox_final.Text, out float finalScore))
            {
                var transcript = new Student_TranscriptDTO
                {
                    TranscriptID = transcriptId,
                    MidtermScore = midtermScore,
                    FinalScore = finalScore
                };

                bool success = subjectBLL.UpdateTranscriptScoresAndStatus(transcript);

                if (success)
                {
                    MessageBox.Show("Cập nhật điểm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadScore(subject); // Tải lại danh sách
                }
                else
                {
                    MessageBox.Show("Cập nhật điểm thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng điểm!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
