using BLL;
using DAL;
using DAL.Models;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Subject : Form
    {
        public SubjectBLL subjectBLL;
        public DepartmentBLL departmentBLL;
        public TrainingProgramBLL trainingProgramBLL;
        public int selectedDepartmentID;
        public int selectedProgramID;
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
    }
}
