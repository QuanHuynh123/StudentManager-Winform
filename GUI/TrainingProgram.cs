using BLL;
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
    public partial class TrainingProgram : Form
    {
        private TrainingProgramBLL trainingProgramBLL;
        private DepartmentBLL departmentBLL;
        private int selectedDepartmentID;
        private string selectedDegree;
        public TrainingProgram()
        {
            InitializeComponent();
            trainingProgramBLL = new TrainingProgramBLL();
            departmentBLL = new DepartmentBLL();
            loadListTrainingProgram();
            loadComboBoxDepartment();
            loadComboBoxDegree();
        }

        public void loadComboBoxDepartment()
        {
            List<DepartmentDTO> departmentDTO = departmentBLL.GetAllDepartments();
            comboBox_department.Items.Clear(); // Xóa các mục cũ trước khi thêm mới
            foreach (var department in departmentDTO)
            {
                comboBox_department.Items.Add(department.DepartmentName);
            }
        }

        public void loadComboBoxDegree()
        {
            comboBox_degree.Items.Clear();
            comboBox_degree.Items.Add("KỸ SƯ");
            comboBox_degree.Items.Add("CỬ NHÂN");
        }

        public void loadListTrainingProgram()
        {
            listViewTrainingProgram.Items.Clear();
            listViewTrainingProgram.FullRowSelect = true;

            List<TrainingProgramDTO> trainingPrograms = trainingProgramBLL.GetAllTrainingPrograms();
            List<DepartmentDTO> departments = departmentBLL.GetAllDepartments();

            foreach (var trainingProgram in trainingPrograms)
            {
                // Tạo một item mới cho mỗi phòng ban
                ListViewItem item = new ListViewItem(trainingProgram.ProgramID.ToString());
                item.SubItems.Add(trainingProgram.ProgramName);
                var department = departments.FirstOrDefault(d => d.DepartmentID == trainingProgram.DepartmentID);
                item.SubItems.Add(department != null ? department.DepartmentName : "Unknown");
                item.SubItems.Add(trainingProgram.Duration.ToString());
                item.SubItems.Add(trainingProgram.StartYear.ToString());
                item.SubItems.Add(trainingProgram.EndYear.ToString());
                item.SubItems.Add(trainingProgram.DegreeAwarded.ToString());
                item.SubItems.Add(trainingProgram.CreditsRequired.ToString());

                // Thêm item vào ListView
                listViewTrainingProgram.Items.Add(item);
            }
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
        private void comboBox_degree_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Lấy text đã chọn từ comboBox_degree
            selectedDegree = comboBox_degree.SelectedItem.ToString();
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn thêm không ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    TrainingProgramDTO newProgram = new TrainingProgramDTO
                    {
                        ProgramName = textBox_programName.Text,
                        DepartmentID = selectedDepartmentID,
                        Duration = int.Parse(textBox_duration.Text),
                        StartYear = int.Parse(textBox_startYear.Text),
                        EndYear = int.Parse(textBox_endYear.Text),
                        DegreeAwarded = selectedDegree,
                        CreditsRequired = int.Parse(textBox_credit.Text)
                    };

                    if (trainingProgramBLL.AddTrainingProgram(newProgram))
                    {
                        MessageBox.Show("Added successfully!");
                        loadListTrainingProgram();
                    }
                    else
                    {
                        MessageBox.Show("Failed to add!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
        }


        private void button_update_Click(object sender, EventArgs e)
        {
            if (listViewTrainingProgram.SelectedItems.Count > 0)
            {
                DialogResult result = MessageBox.Show("Bạn có chắc muốn sửa ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    int programID = int.Parse(listViewTrainingProgram.SelectedItems[0].Text);

                    try
                    {
                        TrainingProgramDTO updatedProgram = new TrainingProgramDTO
                        {
                            ProgramID = programID,
                            ProgramName = textBox_programName.Text,
                            DepartmentID = selectedDepartmentID,
                            Duration = int.Parse(textBox_duration.Text),
                            StartYear = int.Parse(textBox_startYear.Text),
                            EndYear = int.Parse(textBox_endYear.Text),
                            DegreeAwarded = selectedDegree,
                            CreditsRequired = int.Parse(textBox_credit.Text)
                        };

                        if (trainingProgramBLL.UpdateTrainingProgram(updatedProgram))
                        {
                            MessageBox.Show("Updated successfully!");
                            loadListTrainingProgram();
                        }
                        else
                        {
                            MessageBox.Show("Failed to update!");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error: {ex.Message}");
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn chương trình cần cập nhật.");
            }
        }


        private void button_delete_Click(object sender, EventArgs e)
        {
            if (listViewTrainingProgram.SelectedItems.Count > 0)
            {
                DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    int programID = int.Parse(listViewTrainingProgram.SelectedItems[0].Text);

                    if (trainingProgramBLL.DeleteTrainingProgram(programID))
                    {
                        MessageBox.Show("Deleted successfully!");
                        loadListTrainingProgram();
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete!");
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn chương trình cần xóa !.");
            }
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            string searchText = textBoxSearch.Text.Trim();

            try
            {
                if (string.IsNullOrEmpty(searchText))
                {
                    // Nếu không nhập gì thì load lại danh sách gốc
                    loadListTrainingProgram();
                    MessageBox.Show("Trả lại danh sách mặc định .", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Gọi phương thức từ BLL để lấy danh sách kết quả tìm kiếm
                var searchResults = trainingProgramBLL.SearchTrainingPrograms(searchText);

                // Nếu không có kết quả
                if (searchResults == null || searchResults.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy chương trình đào tạo bạn đang cần !.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // Hiển thị kết quả tìm kiếm lên ListView
                    listViewTrainingProgram.Items.Clear();
                    foreach (var program in searchResults)
                    {
                        ListViewItem item = new ListViewItem(program.ProgramID.ToString());
                        item.SubItems.Add(program.ProgramName);
                        item.SubItems.Add(program.DepartmentID.ToString());
                        item.SubItems.Add(program.Duration.ToString());
                        item.SubItems.Add(program.StartYear.ToString());
                        item.SubItems.Add(program.EndYear.ToString());
                        item.SubItems.Add(program.DegreeAwarded);
                        item.SubItems.Add(program.CreditsRequired.ToString());
                        listViewTrainingProgram.Items.Add(item);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error during search: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }






    }
}
